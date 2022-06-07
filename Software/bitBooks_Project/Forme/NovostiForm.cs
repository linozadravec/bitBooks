using Aspose.Pdf;
using bitBooks_Project.Dorian_Iznimke;
using bitBooks_Project.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bitBooks_Project.Forme
{
    public partial class NovostiForm : Form
    {
        Novost odabranaNovost;
        List<Novost> novosti = new List<Novost>();
        NovostiUnos novostiUnosForm;
        int pozicija = 0;

        public NovostiForm()
        {
            InitializeComponent();
        }

        private void NovostiForm_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshGUI();
            }
            catch (UnosNovostiException ex)
            {

                MessageBox.Show(ex.Poruka);
                Close();
            }
            btnIza.Enabled = false;
            
          
        }

        private void RefreshGUI()
        {
            if(Sesija.Korisnik.DohvatiTipKorisnika(Sesija.Korisnik) == "Korisnik")
            {
                btnUredi.Visible = false;
                btnSpremi.Visible = false;
                btnNovo.Visible = false;
            }

            btnSpremi.Enabled = false;
            novosti = NapraviListuNovosti();
            txtNovost.Text = novosti[pozicija].Ime;
            txtOpis.Text = novosti[pozicija].Opis;

            OnemogućiPromjene();
        }

        private void OnemogućiPromjene()
        {
            txtNovost.Enabled = false;
            txtOpis.Enabled = false;
        }

        private void OmogućiPromjene()
        {
                txtNovost.Enabled = true;
                txtOpis.Enabled = true;    
        }

        private static List<Novost> NapraviListuNovosti()
        {
            if (Sesija.Korisnik.DohvatiTipKorisnika(Sesija.Korisnik) == "Super admin")
            {
                return Novost.DohvatiNovostiSve();
            }
            else
            {
                return Novost.DohvatiNovostiKnjiznice(Sesija.Korisnik.KnjiznicaID);
            }
            
        }

        private void BtnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                odabranaNovost.AžurirajNovost(txtNovost.Text, txtOpis.Text, odabranaNovost.NovostId);
            }
            catch (UnosNovostiException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
            RefreshGUI();
        }

        private void BtnUredi_Click(object sender, EventArgs e)
        {
            odabranaNovost = novosti[pozicija];
            OnemogućiPromjene();
            OmogućiPromjene();
            btnSpremi.Enabled = true;
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            novostiUnosForm = new NovostiUnos();
            novostiUnosForm.ShowDialog();
            RefreshGUI();
        }

        private void BtnIza_Click(object sender, EventArgs e)
        {
            
            if (pozicija == 0)
            {
                btnIza.Enabled = false;
            }
            else
            {
                pozicija--;
            }

            if (pozicija == 0)
            {
                btnIza.Enabled = false;
            }
            btnDalje.Enabled = true;
            RefreshGUI();
        }

        private void BtnDalje_Click(object sender, EventArgs e)
        {
            if (pozicija < novosti.Count - 1)
            {
                pozicija++;
                
            }
            else
            {
                btnDalje.Enabled = false;
            }

            if(pozicija == novosti.Count - 1)
            {
                btnDalje.Enabled = false;
            }

            btnIza.Enabled = true;
            RefreshGUI();
        }

    }
}
