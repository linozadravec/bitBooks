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
    public partial class SuperAdminForm : Form
    {
        Knjižnica dohvacenaKnjiznica;
        List<Odjel> odjeliKnjiznice = new List<Odjel>();
        List<Izdanje> izdanjaOdjela = new List<Izdanje>();
        List<Korisnik> korisniciKnjiznice = new List<Korisnik>();
        List<Posudba> posudbeKorisnika = new List<Posudba>();
        List<Rezervacija> rezervacijeKorisnika = new List<Rezervacija>();
        RecenzijaKnjižnice recKnjiznice;
        List<RecenzijaZaposlenika> recZaposlenika = new List<RecenzijaZaposlenika>();
        public SuperAdminForm()
        {
            InitializeComponent();
        }

        private void BtnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SuperAdminForm_Load(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        private void RefreshGUI()
        {
            dgvKnjiznice.DataSource = Knjižnica.DohvatiSveKnjiznice();
            dgvKnjiznice.Columns["Admin"].DisplayIndex = 1;
            dgvKnjiznice.Columns["Ime"].DisplayIndex = 0;
            dgvKnjiznice.Columns["KnjižnicaID"].Visible = false;
        }

        private void BtnAzuriraj_Click(object sender, EventArgs e)
        {
            DohvatiKnjiznicu();
            SuperAdminUpdateForm superAdminUpdateForm = new SuperAdminUpdateForm(dohvacenaKnjiznica);
            superAdminUpdateForm.ShowDialog();
            RefreshGUI();
        }

        private void BtnUnesi_Click(object sender, EventArgs e)
        {
            SuperAdminUnosFOrm superAdminUnosFOrm = new SuperAdminUnosFOrm();
            superAdminUnosFOrm.ShowDialog();
            RefreshGUI();
        }

        private void DohvatiKnjiznicu()
        {
            if (dgvKnjiznice.CurrentRow != null)
            {
                dohvacenaKnjiznica = dgvKnjiznice.CurrentRow.DataBoundItem as Knjižnica;
            }

            else
            {
                dohvacenaKnjiznica = null;
            }
        }

        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            DohvatiKnjiznicu();
            odjeliKnjiznice = Odjel.DohvatiOdjeleKnjiznice(dohvacenaKnjiznica.KnjižnicaID);
            korisniciKnjiznice = Korisnik.DohvatiKorisnikeKnjižnice(dohvacenaKnjiznica.KnjižnicaID);

            

            try
            {
                foreach (Korisnik korisnik in korisniciKnjiznice)
                {
                    posudbeKorisnika = Posudba.DohvatiPosudbeKorisnika(korisnik.KorisnikID);
                    rezervacijeKorisnika = Rezervacija.DohvatiRezervacijeKorisnika(korisnik.KorisnikID);
                    recKnjiznice = RecenzijaKnjižnice.DohvatiKorisnikoveRecenzijeKnjiznice(korisnik.KorisnikID);
                    recZaposlenika = RecenzijaZaposlenika.DohvatiKorisnikoveRecenzijeZaposlenika(korisnik.KorisnikID);

                    if (recKnjiznice != null)
                    {
                        recKnjiznice.ObrisiRecenziju();
                    }
                    

                    foreach (Posudba posudba in posudbeKorisnika)
                    {
                        posudba.ObrisiPosudbu();
                    }
                    foreach (Rezervacija rezervacija in rezervacijeKorisnika)
                    {
                        rezervacija.ObrisiRezervaciju();
                    }
                    foreach (RecenzijaZaposlenika recZ in recZaposlenika)
                    {
                        recZ.ObrisiRecenziju();
                    }
                }

                foreach (Odjel odjel in odjeliKnjiznice)
                {
                    izdanjaOdjela = Izdanje.DohvatiIzdanjaOdjela(odjel.OdjelID);

                    foreach (Izdanje izdanje in izdanjaOdjela)
                    {
                        izdanje.ObrisiIzdanje();
                    }

                    odjel.ObrisiOdjel();
                }

                dohvacenaKnjiznica.ObrisiKnjiznicu();

                foreach(Korisnik korisnik in korisniciKnjiznice)
                {
                    korisnik.ObrisiKorisnika();
                }

            }
            catch (Exception)
            {

                throw;
            }

            RefreshGUI();
        }
    }
}
