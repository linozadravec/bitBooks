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
    public partial class UnosKorisnikaForm : Form
    {
        Knjižnica knjižnica;
        List<Knjižnica> knjižnice = new List<Knjižnica>();

        public UnosKorisnikaForm()
        {
            InitializeComponent();
        }

        private void UnosKorisnikaForm_Load(object sender, EventArgs e)
        {
            
            if (Sesija.Korisnik.TipID == 1)
            {
                
                knjižnice = Knjižnica.DohvatiSveKnjiznice();
                cmbKnjižnica.DataSource = knjižnice;
            }
            else
            {
                knjižnica = Knjižnica.DohvatiKnjiznicuTrenutnogKorisnika();
                knjižnice.Add(knjižnica);
                cmbKnjižnica.DataSource = knjižnice;
                cmbKnjižnica.Enabled = false;
            }
            
            rbtnKorisnik.Checked = true;

        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            Korisnik noviKorisnik = new Korisnik()
            {
                KnjiznicaID = (cmbKnjižnica.SelectedItem as Knjižnica).KnjižnicaID,
                Email = txtEmail.Text,
                Adresa = txtAdresa.Text,
                KorisnickoIme = txtKorIme.Text,
                Lozinka = txtLozinka.Text,
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                AktivacijskiKod = "NEMA",
                DatumRegistracije = DateTime.Now
            };

            if(rbtnKorisnik.Checked == true)
            {
                noviKorisnik.TipID = 4;
            }
            else
            {
                noviKorisnik.TipID = 3;
            }

            Korisnik.NoviKorisnik(noviKorisnik);

            Close();

        }

    }
}
