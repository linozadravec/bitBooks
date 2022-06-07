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
    public partial class AktivacijskiKodForm : Form
    {
        LibraryUser _noviKorisnik;
        public AktivacijskiKodForm(LibraryUser noviKorisnik)
        {
            _noviKorisnik = noviKorisnik;
            InitializeComponent();
        }



        private void btnZavršiRegistraciju_Click(object sender, EventArgs e)
        {
            if(txtAktivacijskiKod.Text == _noviKorisnik.ActivationCode)
            {
                RegistrirajKorisnikaUBazu();
                Close();
            }
            else
            {
                lblGreška.Text = "Neispravan kod";
            }

            
        }

        private void RegistrirajKorisnikaUBazu()
        {
            using (var context = new Entities_db1())
            {
                context.LibraryUsers.Add(_noviKorisnik);
                context.SaveChanges();
                context.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
            }
            
        }

        
    }
    
}
