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
    public partial class MojeRezervacijeForm : Form
    {
        
        public MojeRezervacijeForm()
        {
            InitializeComponent();
        }

        private void MojeRezervacijeForm_Load(object sender, EventArgs e)
        {
            dgvRezervacije.DataSource = Rezervacija.DohvatiRezervacijeKorisnika(Sesija.Korisnik.KorisnikID);         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rezervacija rez = dgvRezervacije.CurrentRow.DataBoundItem as Rezervacija;
            Rezervacija.ObrisiRezervaciju(rez);
            string poruka = " ";
            if (rez==null)
            {
                poruka = "Odaberite rezervaciju koju želite otkazati!";
            }
            else
            {
                poruka = "Rezervacija uspješno otkazana!";
            }
            MessageBox.Show(poruka);
            dgvRezervacije.DataSource = Rezervacija.DohvatiRezervacijeKorisnika(Sesija.Korisnik.KorisnikID);
        }
    }
}
