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
    public partial class UnosOdjelaForm : Form
    {
        List<Knjižnica> knjižnice = new List<Knjižnica>();
        Knjižnica knjižnica;
        public UnosOdjelaForm()
        {
            InitializeComponent();
        }

        private void UnosOdjelaForm_Load(object sender, EventArgs e)
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
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            Odjel noviOdjel = new Odjel()
            {
                KnjižnicaID = (cmbKnjižnica.SelectedItem as Knjižnica).KnjižnicaID,
                PoštanskiBroj = int.Parse(txtPoštanskiBroj.Text),
                Ime = txtImeOdjela.Text,
                Adresa = txtAdresa.Text,
                BrojOdjela = int.Parse(txtBrojOdjela.Text)
            };

            Odjel.NoviOdjel(noviOdjel);

            Close();
        }
    }
}
