using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bitBooks_Project.Klase;
using PodaciOKnjiziDll;

namespace bitBooks_Project.Forme
{
    public partial class OpisKnjigeForm : Form
    {
        Knjiga unesenaknjiga;
        PodaciOKnjizi p = new PodaciOKnjizi();
        public OpisKnjigeForm(Knjiga knjiga)
        {
            unesenaknjiga = knjiga;
            InitializeComponent();
        }

        private void OpisKnjigeForm_Load(object sender, EventArgs e)
        {
            
            txtNaslov.Text = unesenaknjiga.Ime;
            
            
            txtBrStr.Text = p.DohvatiBrojStranica(unesenaknjiga.Ime).ToString();
            txtGodIzd.Text = p.DohvatiDatumIzdavanja(unesenaknjiga.Ime);
             txtIzd.Text = p.DohvatiIzdavačaKnjige(unesenaknjiga.Ime);
             txtRec.Text = p.DohvatiRecenzije(unesenaknjiga.Ime).ToString();
             txtBoxOpis.Text = p.DohvatiOpisKnjige(unesenaknjiga.Ime);

        }
    }
}
