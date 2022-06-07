using bitBooks_Project.Dorian_Iznimke;
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
    public partial class SuperAdminUpdateForm : Form
    {
        Knjižnica _knjiznica;
        public SuperAdminUpdateForm(Knjižnica knjiznica)
        {
            InitializeComponent();
            _knjiznica = knjiznica;
        }

        private void BtnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SuperAdminUpdateForm_Load(object sender, EventArgs e)
        {
            txtImeKnjiznice.Text = _knjiznica.Ime;
            btnSpremi.Enabled = false;
            OnemoguciTextBoxeve();
        }

        private void OnemoguciTextBoxeve()
        {
            txtImeKnjiznice.Enabled = false;
            txtIme.Enabled = false;
            txtPrezime.Enabled = false;
            txtKorisnickoIme.Enabled = false;
            txtLozinka.Enabled = false;
            txtAdresa.Enabled = false;
            txtEmail.Enabled = false;
        }

        private void OmoguciTextBoxeve()
        {
            txtImeKnjiznice.Enabled = true;
            txtIme.Enabled = true;
            txtPrezime.Enabled = true;
            txtKorisnickoIme.Enabled = true;
            txtLozinka.Enabled = true;
            txtAdresa.Enabled = true;
            txtEmail.Enabled = true;
        }

        private void BtnSpremi_Click(object sender, EventArgs e)
        {
            OnemoguciTextBoxeve();
            btnSpremi.Enabled = false;
            try
            {
                _knjiznica.AžurirajKnjiznicu(txtImeKnjiznice.Text);
            }
            catch (KnjiznicaException ex)
            {

                MessageBox.Show(ex.Poruka);
            }
        }

        private void BtnUredi_Click(object sender, EventArgs e)
        {
            OmoguciTextBoxeve();
            btnSpremi.Enabled = true;
        }
    }
}
