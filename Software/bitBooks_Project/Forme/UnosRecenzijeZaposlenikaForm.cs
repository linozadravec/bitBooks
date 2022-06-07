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
    public partial class UnosRecenzijeZaposlenikaForm : Form
    {
        Korisnik odabraniZaposlenik;
        bool recenzijaPostoji;
        RecenzijaZaposlenika novaRecenzija;
        public UnosRecenzijeZaposlenikaForm()
        {
            InitializeComponent();
        }

        private void UnosRecenzijeZaposlenikaForm_Load(object sender, EventArgs e)
        {
            PopuniComboBoxeve();
            DohvatiRecenziju();
            PopuniPodatke();
            OnemogućiPromjene();
            ProvjeriRecenziju();
        }
        private void cmbZaposlenik_SelectedIndexChanged(object sender, EventArgs e)
        {
            odabraniZaposlenik = cmbZaposlenik.SelectedItem as Korisnik;
            DohvatiRecenziju();
            ProvjeriRecenziju();
            OnemogućiPromjene();

            //jer se runna isto dok se i loada a jos nema source
            if (cmbOcjena.Items.Count > 0)
            {
                PopuniPodatke();
            }

        }

        private void ProvjeriRecenziju()
        {
            if (novaRecenzija != null)
            {
                recenzijaPostoji = true;
            }
            else
            {
                recenzijaPostoji = false;
            }
        }

        private void PopuniPodatke()
        {
            txtKnjiznica.Text = Sesija.Korisnik.ImeKnjiznice;
            PostaviPocetnePodatke();

            if (novaRecenzija != null)
            {
                txtDatumUnosa.Text = novaRecenzija.DatumUnosa.ToString();
                txtKomentar.Text = novaRecenzija.TekstRecenzije;
                cmbOcjena.SelectedIndex = novaRecenzija.Ocjena - 1;
            }
        }

        private void PostaviPocetnePodatke()
        {
            txtDatumUnosa.Clear();
            txtKomentar.Clear();
            cmbOcjena.SelectedIndex = 0;
        }

        private void PopuniComboBoxeve()
        {
            cmbZaposlenik.DataSource = Korisnik.DohvatiZaposlenikeKnjižnice(Sesija.Korisnik.KnjiznicaID);
            cmbOcjena.DataSource = RecenzijaZaposlenika.listaOcjena;
        }

        private void DohvatiRecenziju()
        {
            novaRecenzija = RecenzijaZaposlenika.DohvatiSpecificnuRecenziju(Sesija.Korisnik.KorisnikID, odabraniZaposlenik.KorisnikID);
        }

        private void OnemogućiPromjene() 
        {
            txtDatumUnosa.Enabled = false;
            txtKnjiznica.Enabled = false;
            txtKomentar.Enabled = false;
            cmbOcjena.Enabled = false;
            btnSpremi.Enabled = false;
        }

        private void OmogućiPromjene()
        {
            txtKomentar.Enabled = true;
            cmbOcjena.Enabled = true;
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            OmogućiPromjene();
            btnSpremi.Enabled = true;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                if (recenzijaPostoji)
                {
                    novaRecenzija.AžurirajRecenziju(txtKomentar.Text, cmbOcjena.SelectedIndex + 1, Sesija.Korisnik.KorisnikID, odabraniZaposlenik.KorisnikID);
                }
                else
                {
                    novaRecenzija = new RecenzijaZaposlenika();
                    novaRecenzija.NovaRecenzija(txtKomentar.Text, cmbOcjena.SelectedIndex + 1, Sesija.Korisnik, odabraniZaposlenik);
                }
                DohvatiRecenziju();
                PopuniPodatke();
                OnemogućiPromjene();
            }
            catch (RecenzijaException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
            
        }
    }
}
