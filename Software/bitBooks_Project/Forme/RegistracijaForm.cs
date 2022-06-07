using bitBooks_Project.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace bitBooks_Project.Forme
{
    public partial class RegistracijaForm : Form
    {
        
        public List<Knjižnica> knjižnice = new List<Knjižnica>();
        AktivacijskiKodForm aktivacijskiKodFrm;

        MailMessage poruka;
        SmtpClient smtp;

        LibraryUser noviKorisnik;
        public string korisničkoIme;
        public string aktivacijskiKod;
        public RegistracijaForm()
        {
            InitializeComponent();
        }

        private void RegistracijaForm_Load(object sender, EventArgs e)
        {
            knjižnice = Knjižnica.DohvatiSveKnjiznice();
            cmbKnjižnice.DataSource = knjižnice;


        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {

            if(ProvjeraLozinki() && ProvjeraEmail() && ProvjeraPopunjenosti())
            {
                lblGreška.Text = "";
                Korisnik istoimeniKorisnik = Korisnik.DohvatiKorisnikaPoEmailu(txtEmail.Text);
                if(istoimeniKorisnik == null)
                {
                    lblGreška.Text = "";

                    GeneriranjeAktKoda();
                    GeneriranjeKorisničkogImena();

                    SlanjeEmailaSaAktKodom();

                    GeneriranjeLibraryUsera();

                    aktivacijskiKodFrm = new AktivacijskiKodForm(noviKorisnik);
                    aktivacijskiKodFrm.ShowDialog();
                    Close();
                    Obavijest.GeneriranjeObavijestiRegistracije(noviKorisnik.UserID);
                }
                else
                {
                    lblGreška.Text = "Korisnik već postoji!";
                }
            }
            else
            {
                lblGreška.Text = "Nisu ispravno popunjena sva polja";
            }
        }

        private void GeneriranjeLibraryUsera()
        {
            using (var context = new Entities_db1())
                noviKorisnik = new LibraryUser
                {
                    TypeID = 4,
                    LibraryID = (cmbKnjižnice.SelectedItem as Knjižnica).KnjižnicaID,
                    Email = txtEmail.Text,
                    Adress = txtAdresa.Text,
                    Username = korisničkoIme,
                    Password = txtLozinka.Text,
                    Name = txtIme.Text,
                    Surname = txtPrezime.Text,
                    ActivationCode = aktivacijskiKod,
                    DateTimeRegistration = DateTime.Now
        };
        }

        private void GeneriranjeKorisničkogImena()
        {
            Random randObjekt = new Random();
            korisničkoIme = txtIme.Text.Substring(0, 1) + txtPrezime.Text + randObjekt.Next(100);
        }

    private void GeneriranjeAktKoda()
        {
            aktivacijskiKod = Guid.NewGuid().ToString().Substring(0,4);
        }

        private void SlanjeEmailaSaAktKodom()
        {

            try
            {
                poruka = new MailMessage();

                poruka.IsBodyHtml = true;

                poruka.To.Add(new MailAddress(txtEmail.Text));  

                poruka.Subject = "bitBooks Podaci za registraciju";

                poruka.From = new MailAddress("PIbitBooks@gmail.com");

                poruka.Body = "Poštovani," + "<br>" + 
                               "Vaše bitBooks korisničko ime je: " + korisničkoIme + "<br>" + 
                               "Vaš aktivacijski kod je: " + aktivacijskiKod + "<br>" +
                               "bitBooks";
                

                smtp = new SmtpClient();

                smtp.Port = 587;

                smtp.EnableSsl = true;

                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;

                smtp.Credentials = new NetworkCredential("PIbitBooks@gmail.com", "bitBooksPI");

                smtp.Host = "smtp.gmail.com";

                smtp.EnableSsl = true;

                smtp.Send(poruka);

                smtp.SendCompleted += new SendCompletedEventHandler(smtp_SendCompleted);

            }

            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
                Console.WriteLine("InnerException is: {0}", ex.InnerException);

            }
        }

        void smtp_SendCompleted(object sender, AsyncCompletedEventArgs e)

        {

            if (e.Cancelled == true)

            {

                MessageBox.Show("Email sending cancelled!");

            }

            else if (e.Error != null)

            {

                MessageBox.Show(e.Error.Message);

            }

            else

            {

                MessageBox.Show("Email sent sucessfully!");

            }

        }

        private bool ProvjeraPopunjenosti()
        {
            if(!String.IsNullOrWhiteSpace(txtIme.Text) && !String.IsNullOrWhiteSpace(txtPrezime.Text) && !String.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ProvjeraLozinki()
        {
            if(txtLozinka.Text == txtPotvrdaLozinke.Text && !String.IsNullOrWhiteSpace(txtLozinka.Text) && !String.IsNullOrWhiteSpace(txtPotvrdaLozinke.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool ProvjeraEmail()
        {
            try
            {
                var adresa = new MailAddress(txtEmail.Text);
                return adresa.Address == txtEmail.Text;
            }
            catch
            {
                return false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
