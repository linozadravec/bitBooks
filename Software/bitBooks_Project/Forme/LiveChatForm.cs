using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using bitBooks_Project.Klase;

namespace bitBooks_Project.Forme
{
    public partial class LiveChatForm : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;
        Korisnik korisnik;

        Zahtjev _zahtjev;

        public LiveChatForm(Zahtjev zahtjev)
        {
            _zahtjev = zahtjev;

            InitializeComponent();
        }

        private void LiveChatForm_Load(object sender, EventArgs e)
        {
            korisnik=Korisnik.DohvatiKorisnikaPoID(_zahtjev.KorisnikID);

            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);


            Spoji();

            //txtIPJa.Text = GetLocalIP();

            //txtIPPrijatelj.Text = GetLocalIP();

           
        }
        

        /*
        private void btnSpoji_Click(object sender, EventArgs e)
        {
            epLocal = new IPEndPoint(IPAddress.Parse(txtIPJa.Text), Convert.ToInt32(txtPortJa.Text));
            sck.Bind(epLocal);

            epRemote = new IPEndPoint(IPAddress.Parse(txtIPPrijatelj.Text), Convert.ToInt32(txtPortPrijatelj.Text));
            sck.Connect(epRemote);

            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
        }
        */

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;

                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);

                //listPoruka.Items.Add("Friend: " + receivedMessage);
                string titula;
                if (Sesija.Korisnik.TipID < 4)
                {
                    titula = korisnik.Ime + " " + korisnik.Prezime +  ": ";
                }
                else
                {
                    titula = "Zaposlenik: ";
                    
                }

                if (IsHandleCreated)
                {
                    listPoruka.Invoke(new Action(() => listPoruka.Items.Add(titula + receivedMessage)));
                }

                

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnPošalji_Click(object sender, EventArgs e)
        {
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(txtPoruka.Text);

            sck.Send(sendingMessage);


            listPoruka.Items.Add("Ja: " + txtPoruka.Text);
            txtPoruka.Text = "";
        }



        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();

            }


            return "127.0.0.1";
        }

        private void Spoji()
        {
            if(Sesija.Korisnik.TipID < 4)
            {
                epLocal = new IPEndPoint(IPAddress.Parse(_zahtjev.AdresaIPZaposlenik), Convert.ToInt32("80"));
                sck.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(_zahtjev.AdresaIPKorisnik), Convert.ToInt32("81"));
                sck.Connect(epRemote);
            }
            else
            {
                epLocal = new IPEndPoint(IPAddress.Parse(_zahtjev.AdresaIPKorisnik), Convert.ToInt32("81"));
                sck.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(_zahtjev.AdresaIPZaposlenik), Convert.ToInt32("80"));
                sck.Connect(epRemote);
            }
            

            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
        }

    }
}
