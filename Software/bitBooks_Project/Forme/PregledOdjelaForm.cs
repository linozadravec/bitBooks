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
    public partial class PregledOdjelaForm : Form
    {
        UnosOdjelaForm unosOdjelaForm;
        Odjel označeniOdjel;
        AžuriranjeOdjelaForm ažuriranjeOdjelaForm;

        public PregledOdjelaForm()
        {
            InitializeComponent();
        }

        private void PregledOdjelaForm_Load(object sender, EventArgs e)
        {
            UčitajOdjeleDGV();
        }

        private void UčitajOdjeleDGV()
        {       
            dgvOdjeli.DataSource = Odjel.DohvatiOdjeleKnjiznice(Sesija.Korisnik.KnjiznicaID);
        }

        private void btnUnesiOdjel_Click(object sender, EventArgs e)
        {
            unosOdjelaForm = new UnosOdjelaForm();
            unosOdjelaForm.ShowDialog();

            UčitajOdjeleDGV();
        }

        private void btnObrišiOdjel_Click(object sender, EventArgs e)
        {
            DohvatiOdjel();
           /* try
            {
                Odjel.ObrisiOdjel(označeniOdjel);
            }
            catch (AdminException ex)
            {
                MessageBox.Show(ex.Poruka);
            }
            */
        }

        private void DohvatiOdjel()
        {
            if (dgvOdjeli.CurrentRow != null)
            {
                označeniOdjel = dgvOdjeli.CurrentRow.DataBoundItem as Odjel;
            }
        }

        private void btnAžuriraj_Click(object sender, EventArgs e)
        {
            DohvatiOdjel();

            if(označeniOdjel!= null)
            {
                ažuriranjeOdjelaForm = new AžuriranjeOdjelaForm(označeniOdjel);
                ažuriranjeOdjelaForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Niste označili odjel");
            }
            

            UčitajOdjeleDGV();
        }
    }
}
