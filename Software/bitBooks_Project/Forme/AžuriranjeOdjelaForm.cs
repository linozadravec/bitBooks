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
    public partial class AžuriranjeOdjelaForm : Form
    {
        Odjel _odjel;

        public AžuriranjeOdjelaForm(Odjel proslijeđeniOdjel)
        {
            _odjel = proslijeđeniOdjel;
            InitializeComponent();
        }


        private void AžuriranjeOdjelaForm_Load(object sender, EventArgs e)
        {
            txtID.Text = _odjel.OdjelID.ToString();
            txtID.Enabled = false;
            txtAdresa.Text = _odjel.Adresa;
            txtBrojOdjela.Text = _odjel.BrojOdjela.ToString();
            txtImeOdjela.Text = _odjel.Ime;
            txtPoštanskiBroj.Text = _odjel.PoštanskiBroj.ToString();
        }

        private void btnAžuriraj_Click(object sender, EventArgs e)
        {
            Odjel odjelAžuriranje = new Odjel
            {
                OdjelID = int.Parse(txtID.Text),
                Ime = txtImeOdjela.Text,
                Adresa = txtAdresa.Text,
                PoštanskiBroj = int.Parse(txtPoštanskiBroj.Text),
                BrojOdjela = int.Parse(txtBrojOdjela.Text)
            };


            Odjel.AžurirajOdjel(odjelAžuriranje);
            Close();
        }
    }
}
