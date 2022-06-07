using bitBooks_Project.Forme;
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

namespace bitBooks_Project
{
    public partial class PregledRecenzijaForm : Form
    {
        Korisnik odabraniZaposlenik;
        UnosRecenzijeKnjižniceForm unosRecenzijeKnjizniceForm;
        UnosRecenzijeZaposlenikaForm unosRecenzijeZaposlenikaForm;
        public PregledRecenzijaForm()
        {
            InitializeComponent();
        }

        private void PregledRecenzijaForm_Load(object sender, EventArgs e)
        {
            PrikaziRecenzijeKnjiznice();
            PopuniComboBox();
            if(Sesija.Korisnik.TipID == 1)
            {
                grpBoxRecenzije.Visible = false;
            }
        }

        private void PopuniComboBox()
        {
            if (Sesija.Korisnik.TipID == 1)
            {
                cmbZaposlenik.DataSource = Korisnik.DohvatiSveZaposlenike();
            }
            else
            {
                cmbZaposlenik.DataSource = Korisnik.DohvatiZaposlenikeKnjižnice(Sesija.Korisnik.KnjiznicaID);
            }
           
        }

        private void btnRecenzijeKnjiznice_Click(object sender, EventArgs e)
        {
            PrikaziRecenzijeKnjiznice();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRecenzijeZaposlenika_Click(object sender, EventArgs e)
        {
            PrikaziRecenzijeSvihZaposlenika();
        }
        private void PrikaziRecenzijeKnjiznice()
        {
            if (Sesija.Korisnik.TipID == 1)
            {
                dgvRecenzije.DataSource = RecenzijaKnjižnice.DohvatiSveRecenzije();
            }
            else
            {
                dgvRecenzije.DataSource = RecenzijaKnjižnice.DohvatiSveRecenzijeKnjiznice(Sesija.Korisnik.KnjiznicaID);
            }
            
            FilitrirajDGV();
        }

        private void FilitrirajDGV()
        {
            dgvRecenzije.Columns["ImeKnjižnice"].HeaderText = "Ime knjižnice";
            dgvRecenzije.Columns["KorisnickoIme"].HeaderText = "Korisničko ime";
            dgvRecenzije.Columns["TekstRecenzije"].HeaderText = "Tekst recenzije";
            dgvRecenzije.Columns["DatumUnosa"].HeaderText = "Datum unosa";
            dgvRecenzije.Columns["RecenzijaID"].Visible = false;
            dgvRecenzije.Columns["KnjižnicaID"].Visible = false;
            dgvRecenzije.Columns["KorisnikID"].Visible = false;
        }

        private void PrikaziRecenzijeSvihZaposlenika()
        {
            if (Sesija.Korisnik.TipID == 1)
            {
                dgvRecenzije.DataSource = RecenzijaZaposlenika.DohvatiSveRecenzije();
            }
            else
            {
                dgvRecenzije.DataSource = RecenzijaZaposlenika.DohvatiSveRecenzijeZaposlenikaKnjiznice(Sesija.Korisnik.KnjiznicaID);
            }
            
            ZaposleniciDGV();
        }

        private void ZaposleniciDGV()
        {
            dgvRecenzije.Columns["ImeZaposlenika"].HeaderText = "Ime zaposlenika";
            dgvRecenzije.Columns["ImeZaposlenika"].DisplayIndex = 0;
            dgvRecenzije.Columns["PrezimeZaposlenika"].DisplayIndex = 1;
            dgvRecenzije.Columns["PrezimeZaposlenika"].HeaderText = "Prezime zaposlenika";
            dgvRecenzije.Columns["KorisnickoIme"].HeaderText = "Korisničko ime";
            dgvRecenzije.Columns["TekstRecenzije"].HeaderText = "Tekst recenzije";
            dgvRecenzije.Columns["DatumUnosa"].HeaderText = "Datum unosa";
            dgvRecenzije.Columns["RecenzijaID"].Visible = false;
            dgvRecenzije.Columns["ZaposlenikID"].Visible = false;
            dgvRecenzije.Columns["KorisnikID"].Visible = false;
        }

        private void btnUnosRecenzijeZaKnjiznicu_Click(object sender, EventArgs e)
        {
            unosRecenzijeKnjizniceForm = new UnosRecenzijeKnjižniceForm();
            unosRecenzijeKnjizniceForm.ShowDialog();
            PrikaziRecenzijeKnjiznice();
        }

        private void btnUnosRecenzijeZaZaposlenika_Click(object sender, EventArgs e)
        {
            unosRecenzijeZaposlenikaForm = new UnosRecenzijeZaposlenikaForm();
            unosRecenzijeZaposlenikaForm.ShowDialog();
            PrikaziRecenzijeSvihZaposlenika();
        }

        private void btnOdredeniZaposlenik_Click(object sender, EventArgs e)
        {
            DohvatiZaposlenika();
            PrikaziRecenzijeOdredenogZaposlenika();
        }

        private void DohvatiZaposlenika() 
        {
            odabraniZaposlenik = Korisnik.DohvatiKorisnikaPoID((cmbZaposlenik.SelectedItem as Korisnik).KorisnikID);
        }

        private void PrikaziRecenzijeOdredenogZaposlenika() 
        {
            dgvRecenzije.DataSource = RecenzijaZaposlenika.DohvatiRecenzijeOdredenogZaposlenika(odabraniZaposlenik.KnjiznicaID, odabraniZaposlenik.KorisnikID);
            ZaposleniciDGV();
        }

    }
}
