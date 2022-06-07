using bitBooks_Project.Forme;
using bitBooks_Project.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bitBooks_Project
{
    public partial class bitBooksMainForm : Form
    {
        
        PregledClanovaForm pregledClanovaForm;
        PregledRecenzijaForm pregledRecenzijaForm;      
        ObavijestiForm obavijesti;
        
        PregledKnjigaForm pregledKnjigaForm;
        NovostiForm novostiForm;
        PregledKnjigaZaposlenikForm pregledKnjigaZaposlenikForm;
        LiveChatČekanjeForm liveChatČekanjeForm;
        LiveChatForm liveChatForm;
        PregledOdjelaForm pregledOdjelaForm;

        SuperAdminForm knjizniceForm;

        Timer timer3Sec;
        Zahtjev zahtjev;

        public bitBooksMainForm()
        {    
            InitializeComponent();
        }

        private void bitBooksMainForm_Load(object sender, EventArgs e)
        {
            string projectDirectory = Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName;
            projectDirectory = projectDirectory + "/Korisnička_Dokumentacija/KorisničkaDokumentacija.chm";
            helpProvider1.HelpNamespace = projectDirectory;


            groupBox3.Visible = false;
            grpAdmin.Visible = false;
            btnLiveChat.Visible = false;
            btnPrihvatiLivechat.Visible = false;
            btnKnjižnice.Visible = false;
            if (Sesija.Korisnik.DohvatiTipKorisnika(Sesija.Korisnik)=="Korisnik")
            {
                groupBox3.Visible = true;
                btnLiveChat.Visible = true;
            }
            else
            {
                ZapocniTimer();
                grpAdmin.Visible = true;
                groupBox3.Visible = true;
            }

            if (Sesija.Korisnik.DohvatiTipKorisnika(Sesija.Korisnik) == "Super admin")
            {
                btnKnjižnice.Visible = true;
            }

            labKnjiznica.Text = Sesija.Korisnik.ImeKnjiznice;
            labKorIme.Text = Sesija.Korisnik.KorisnickoIme;
        }

        private void btnRecenzije_Click(object sender, EventArgs e)
        {
            pregledRecenzijaForm = new PregledRecenzijaForm();
            pregledRecenzijaForm.ShowDialog();
        }

        private void obavijesti_button_Click(object sender, EventArgs e)
        {
            obavijesti = new ObavijestiForm();
            obavijesti.ShowDialog();
        }

        private void btnLiveChat_Click(object sender, EventArgs e)
        {
            zahtjev = Zahtjev.NoviZahtjev();

            liveChatČekanjeForm = new LiveChatČekanjeForm(zahtjev);
            liveChatČekanjeForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pregledKnjigaForm = new PregledKnjigaForm();
            pregledKnjigaForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            novostiForm = new NovostiForm();
            novostiForm.ShowDialog();
        }

        private void btnRezervacije_Click(object sender, EventArgs e)
        {
            MojeRezervacijeForm rez = new MojeRezervacijeForm();
            rez.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pregledClanovaForm = new PregledClanovaForm();
            pregledClanovaForm.ShowDialog();
        }

        private void btnPosudbe_Click(object sender, EventArgs e)
        {
            MojePosudbeForm pos = new MojePosudbeForm();
            pos.ShowDialog();
        }

        private void btnPregledKnjiga_Click(object sender, EventArgs e)
        {
            pregledKnjigaZaposlenikForm = new PregledKnjigaZaposlenikForm();
            pregledKnjigaZaposlenikForm.ShowDialog();
        }

        public void ZapocniTimer()
        {
            timer3Sec = new Timer();
            timer3Sec.Tick += new EventHandler(timer3Sec_Tick);
            timer3Sec.Interval = 3000;
            timer3Sec.Start();
        }

        private void timer3Sec_Tick(object sender, EventArgs e)
        {
            zahtjev = Zahtjev.DohvatiNoviZahtjev();

            if(zahtjev == null)
            {
                btnPrihvatiLivechat.Visible = false;
            }
            else
            {
                btnPrihvatiLivechat.Visible = true;
            }

            
        }

        private void btnPrihvatiLivechat_Click(object sender, EventArgs e)
        {
            
            Zahtjev azuriraniZahtjev = Zahtjev.AžurirajZahtjev(zahtjev.ZahtjevID, Sesija.Korisnik.KorisnikID);
            liveChatForm = new LiveChatForm(azuriraniZahtjev);
            liveChatForm.ShowDialog();
        }

        private void btnPregledOdjela_Click(object sender, EventArgs e)
        {
            pregledOdjelaForm = new PregledOdjelaForm();
            pregledOdjelaForm.ShowDialog();
        }

        private void btnKnjižnice_Click(object sender, EventArgs e)
        {
            SuperAdminForm superAdminForm = new SuperAdminForm();
            superAdminForm.ShowDialog();
        }

        private void BtnKnjižnice_Click_1(object sender, EventArgs e)
        {
            knjizniceForm = new SuperAdminForm();
            knjizniceForm.ShowDialog();
        }

     
    }
}
