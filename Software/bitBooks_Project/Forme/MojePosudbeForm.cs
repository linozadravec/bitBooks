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
    public partial class MojePosudbeForm : Form
    {
        public MojePosudbeForm()
        {
            InitializeComponent();
        }

        private void MojePosudbeForm_Load(object sender, EventArgs e)
        {
            dgvPosudba.DataSource = Posudba.DohvatiPosudbeKorisnika(Sesija.Korisnik.KorisnikID);
        }
    }
}
