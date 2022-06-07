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
    public partial class PregledClanova_PosudbeIRezervacijeForm : Form
    {
        Korisnik _odabraniKorisnik;
        public PregledClanova_PosudbeIRezervacijeForm(Korisnik odabraniKorisnik)
        {
            _odabraniKorisnik = odabraniKorisnik;
            InitializeComponent();
        }

        private void PregledClanova_PosudbeIRezervacijeForm_Load(object sender, EventArgs e)
        {
            PopuniPodatke();
        }

        private void PopuniPodatke()
        {
            txtIme.Enabled = false;
            txtPrezime.Enabled = false;
            txtUsername.Enabled = false;
            txtIme.Text = _odabraniKorisnik.Ime;
            txtPrezime.Text = _odabraniKorisnik.Prezime;
            txtUsername.Text = _odabraniKorisnik.KorisnickoIme;
        }

        private void BtnPosudbe_Click(object sender, EventArgs e)
        {
            dgvPodaci.DataSource = Posudba.DohvatiPosudbeKorisnika(_odabraniKorisnik.KorisnikID);
            DGVPosudba();
        }

        private void DGVPosudba()
        {
            dgvPodaci.Columns["PosudbaID"].Visible = false;
            dgvPodaci.Columns["KorisnikID"].Visible = false;
            dgvPodaci.Columns["IzdanjeID"].HeaderText = "Izdanje ID";
            dgvPodaci.Columns["DatumPovratka"].HeaderText = "Datum povratka";
            dgvPodaci.Columns["StatusPosudbe"].HeaderText = "Status posudbe";

            int brojac = 0;

            foreach (Posudba item in Posudba.DohvatiPosudbeKorisnika(_odabraniKorisnik.KorisnikID))
            {
                if (item.StatusPosudbe == "Zakasnjela")
                {
                    dgvPodaci.Rows[brojac].DefaultCellStyle.BackColor = Color.Red;
                }

                else if (item.StatusPosudbe == "Vracena")
                {
                    dgvPodaci.Rows[brojac].DefaultCellStyle.BackColor = Color.Green;
                }

                else if (item.StatusPosudbe == "Posudena")
                {
                    dgvPodaci.Rows[brojac].DefaultCellStyle.BackColor = Color.Yellow;
                }

                brojac++;
            }
        }

        private void BtnRezervacije_Click(object sender, EventArgs e)
        {
            dgvPodaci.DataSource = Rezervacija.DohvatiRezervacijeKorisnika(_odabraniKorisnik.KorisnikID);
            DGVRezervacija();
        }

        private void DGVRezervacija()
        {
            dgvPodaci.Columns["RezervacijaID"].Visible = false;
            dgvPodaci.Columns["KorisnikID"].Visible = false;
            dgvPodaci.Columns["IzdanjeID"].HeaderText = "Izdanje ID";
            dgvPodaci.Columns["DatumRezervacije"].HeaderText = "Datum rezervacije";
            dgvPodaci.Columns["DatumDostupnosti"].HeaderText = "Datum dostupnosti";
        }

        private void BtnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
