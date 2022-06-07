using bitBooks_Project.Dorian_Iznimke;
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

namespace bitBooks_Project.Forme
{
    public partial class SuperAdminUnosFOrm : Form
    {
        LibraryUser admin;
        Library knjiznica;
        Korisnik _admin;
        public SuperAdminUnosFOrm()
        {
            InitializeComponent();
        }

        private void BtnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNapraviAdmina_Click(object sender, EventArgs e)
        {
            try
            {
                admin = Korisnik.NoviAdmin(txtMail.Text, txtAdresa.Text, txtKorisnickoIme.Text, txtLozinka.Text, txtIme.Text, txtPrezime.Text);
                _admin = Korisnik.DohvatiKorisnikaPoID(admin.UserID);
                btnSpremi.Enabled = true;
            }
            catch (KorisnikException ex)
            {

                MessageBox.Show(ex.Poruka);
            }
            
        }

        private void SuperAdminUnosFOrm_Load(object sender, EventArgs e)
        {
            btnSpremi.Enabled = false;
        }

        private void BtnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                knjiznica = Knjižnica.NovaKnjiznica(txtImeKnjiznice.Text, admin.UserID);
                _admin.AžurirajAdmina(knjiznica.LibraryID);
                btnSpremi.Enabled = false;
                IsprazniTextBoxeve();
            }
            catch (KnjiznicaException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }

        private void IsprazniTextBoxeve()
        {
            txtImeKnjiznice.Text = "";
            txtAdresa.Text = "";
            txtIme.Text = "";
            txtKorisnickoIme.Text = "";
            txtLozinka.Text = "";
            txtMail.Text = "";
            txtPrezime.Text = "";
        }
    }
}
