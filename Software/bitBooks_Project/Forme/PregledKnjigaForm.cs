using bitBooks_Project.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bitBooks_Project.Forme
{
    public partial class PregledKnjigaForm : Form
    {
        MailMessage poruka;
        SmtpClient smtp;

        public PregledKnjigaForm()
        {
            InitializeComponent();
        }

        private void PregledKnjigaForm_Load(object sender, EventArgs e)
        {
            dgvKnjige.DataSource = Knjiga.DohvatiNedostupneKnjige();
            dgvKnjigPosudbe.DataSource = Knjiga.DohvatiKnjige();

        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            if(dgvKnjige.CurrentRow != null)
            {
                Knjiga knjiga = dgvKnjige.CurrentRow.DataBoundItem as Knjiga;
                RezervacijaForm rezervacija = new RezervacijaForm(knjiga);
                rezervacija.ShowDialog();
            }
            
        }

        private void btnPosudi_Click(object sender, EventArgs e)
        {
            if (dgvKnjigPosudbe.CurrentRow != null)
            {
                Knjiga knjiga = dgvKnjigPosudbe.CurrentRow.DataBoundItem as Knjiga;
                PosudbaForm pos = new PosudbaForm(knjiga);
                
                
                pos.ShowDialog();
            }
        }

        

        private void OpisPos_Click(object sender, EventArgs e)
        {
            if (dgvKnjigPosudbe.CurrentRow != null)
            {
                Knjiga knjiga = dgvKnjigPosudbe.CurrentRow.DataBoundItem as Knjiga;
                OpisKnjigeForm forma = new OpisKnjigeForm(knjiga);
                forma.ShowDialog();
            }
        }
    }
}
