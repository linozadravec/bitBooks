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
    public partial class LiveChatČekanjeForm : Form
    {
        LiveChatForm liveChatForm;

        Timer timer3Sec;
        Zahtjev zahtjev;

        Zahtjev _korisnikovZahtjev;

        public LiveChatČekanjeForm(Zahtjev korisnikovZahtjev)
        {
            _korisnikovZahtjev = korisnikovZahtjev;
            InitializeComponent();
        }

        private void LiveChatČekanjeForm_Load(object sender, EventArgs e)
        {
            ZapocniTimer();
        }

        public void ZapocniTimer()
        {
            timer3Sec = new Timer();
            timer3Sec.Tick += new EventHandler(Timer3Sec_Tick);
            timer3Sec.Interval = 5000;
            timer3Sec.Start();

        }

        private void Timer3Sec_Tick(object sender, EventArgs e)
        {
            zahtjev = Zahtjev.DohvatiZahtjevPoID(_korisnikovZahtjev.ZahtjevID);

            if(zahtjev.ZaposlenikID != null)
            {
                timer3Sec.Stop();
                this.Hide();
                liveChatForm = new LiveChatForm(zahtjev);
                liveChatForm.ShowDialog();
                

            }

        }
    }
}
