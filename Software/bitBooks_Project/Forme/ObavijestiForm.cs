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
    public partial class ObavijestiForm : Form
    {
        public ObavijestiForm()
        {
            InitializeComponent();
        }

        private void zatvori_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ObavijestiForm_Load(object sender, EventArgs e)
        {
            txtIme.Text = Sesija.Korisnik.KorisnickoIme;

            dgvObavijesti.DataSource = Obavijest.DohvatiObavijestiKorisnika(Sesija.Korisnik.KorisnikID);
            dgvObavijesti.Columns["KorisnikID"].Visible = false;
            DataGridViewColumn column = dgvObavijesti.Columns[1];
            column.Width = 500;
        }
    }
}
