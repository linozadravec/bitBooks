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
    public partial class AžuriranjeKorisnikaForm : Form
    {
        Korisnik _odabraniKorisnik;
        public AžuriranjeKorisnikaForm(Korisnik proslijeđeniKorisnik)
        {
            _odabraniKorisnik = proslijeđeniKorisnik;
            InitializeComponent();
        }

        private void AžuriranjeKorisnikaForm_Load(object sender, EventArgs e)
        {
            if(_odabraniKorisnik.TipID == 3)
            {
                rbtnZaposlenik.Checked = true;
            }
            else
            {
                rbtnKorisnik.Checked = true;
            }
            txtID.Text = _odabraniKorisnik.KorisnikID.ToString();
            txtID.Enabled = false;
            cmbKnjižnica.DataSource = Knjižnica.DohvatiSveKnjiznice();
            txtIme.Text = _odabraniKorisnik.Ime;
            txtPrezime.Text = _odabraniKorisnik.Prezime;
            txtEmail.Text = _odabraniKorisnik.Email;
            txtAdresa.Text = _odabraniKorisnik.Adresa;
            txtKorIme.Text = _odabraniKorisnik.KorisnickoIme;
            txtLozinka.Text = _odabraniKorisnik.Lozinka;

        }

        private void btnAžuriraj_Click(object sender, EventArgs e)
        {
            int tip;
            if (rbtnKorisnik.Checked == true)
            {
                tip = 4;
            }
            else
            {
                tip = 3;
            }

            Korisnik ažuriraniKorisnik = new Korisnik
            {
                KorisnikID = int.Parse(txtID.Text),
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Email = txtEmail.Text,
                Adresa = txtAdresa.Text,
                KorisnickoIme = txtKorIme.Text,
                Lozinka = txtLozinka.Text,
                KnjiznicaID = (cmbKnjižnica.SelectedItem as Knjižnica).KnjižnicaID,
                TipID = tip

            };
            Korisnik.AžurirajKorisnika(ažuriraniKorisnik);
            Close();
        }
    }
}
