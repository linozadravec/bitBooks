using AForge.Video;
using AForge.Video.DirectShow;
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
using ZXing;

namespace bitBooks_Project.Forme
{
    public partial class PregledKnjigaZaposlenikForm : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        public PregledKnjigaZaposlenikForm()
        {
            InitializeComponent();
        }

        private void PregledKnjigaZaposlenikForm_Load(object sender, EventArgs e)
        {
            dgvKnjige.DataSource = Knjiga.DohvatiKnjige();
            dgvKnjige.Columns["ŽanrID"].Visible = false;
            dgvKnjige.Columns["GodinaPisanja"].Visible = false;

            dgvKnjige.Columns[0].Width = 60;
            dgvKnjige.Columns[1].Width = dgvKnjige.Width - 110;

            dgvKorisnici.DataSource = Korisnik.DohvatiSveKorisnike();
            dgvKorisnici.Columns["KorisnikID"].Visible = false;
            dgvKorisnici.Columns["ImeTipa"].Visible = false;
            dgvKorisnici.Columns["ImeKnjiznice"].Visible = false;
            dgvKorisnici.Columns["KnjiznicaID"].Visible = false;
            dgvKorisnici.Columns["TipID"].Visible = false;
            dgvKorisnici.Columns["Lozinka"].Visible = false;
            dgvKorisnici.Columns["AktivacijskiKod"].Visible = false;
            dgvKorisnici.Columns["DatumRegistracije"].Visible = false;
            dgvKorisnici.Columns["Ime"].DisplayIndex = 0;
            dgvKorisnici.Columns["Prezime"].DisplayIndex = 1;
            dgvKorisnici.Columns["Email"].DisplayIndex = 2;
            dgvKorisnici.Columns["Adresa"].DisplayIndex = 3;
            dgvKorisnici.Columns["KorisnickoIme"].DisplayIndex = 4;

            dgvRezervacije.DataSource = Korisnik.DohvatiSveKorisnike();
            dgvRezervacije.Columns["KorisnikID"].Visible = false;
            dgvRezervacije.Columns["ImeTipa"].Visible = false;
            dgvRezervacije.Columns["ImeKnjiznice"].Visible = false;
            dgvRezervacije.Columns["KnjiznicaID"].Visible = false;
            dgvRezervacije.Columns["TipID"].Visible = false;
            dgvRezervacije.Columns["Lozinka"].Visible = false;
            dgvRezervacije.Columns["AktivacijskiKod"].Visible = false;
            dgvRezervacije.Columns["DatumRegistracije"].Visible = false;
            dgvRezervacije.Columns["Ime"].DisplayIndex = 0;
            dgvRezervacije.Columns["Prezime"].DisplayIndex = 1;
            dgvRezervacije.Columns["Email"].DisplayIndex = 2;
            dgvRezervacije.Columns["Adresa"].DisplayIndex = 3;
            dgvRezervacije.Columns["KorisnickoIme"].DisplayIndex = 4;



            cmbPretrazivanje.Items.Add("ISBN");
            cmbPretrazivanje.Items.Add("Naziv knjige");
            cmbPretrazivanje.SelectedIndex = 0;
            cmbPretrazivanje.DropDownStyle = ComboBoxStyle.DropDownList;

            for(int i = 1; i < 7; i++) 
            {
                cmbBrojNaljepnica.Items.Add(i);
            }
            
            cmbBrojNaljepnica.SelectedIndex = 0;
            cmbBrojNaljepnica.DropDownStyle = ComboBoxStyle.DropDownList;

            dgvKnjige.Rows[0].Selected = true;

            dgvIzdanja.DataSource = Izdanje.DohvatiIzdanjaKnjige(dgvKnjige.CurrentRow.Cells[0].Value.ToString());

            dgvIzdanja.Columns["OdjelID"].Visible = false;
            dgvIzdanja.Columns["ISBN"].Visible = false;
            dgvIzdanja.Columns["IzdavacID"].Visible = false;
            dgvIzdanja.Columns["GodinaIzdavanja"].Visible = false;
            dgvIzdanja.Columns["IzdanjeID"].DisplayIndex = 1;
            dgvIzdanja.Columns["BrojPosudenih"].DisplayIndex = 2;
            dgvIzdanja.Columns["BrojDostupnih"].DisplayIndex = 3;

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo device in filterInfoCollection)
            {
                comboBox1.Items.Add(device.Name);
            }
            comboBox1.SelectedIndex = 0;

            List<Korisnik> korisniciCMB = Korisnik.DohvatiKorisnikeKnjižnice(Sesija.Korisnik.KnjiznicaID);
            foreach (Korisnik item in korisniciCMB)
            {
                cmbKorisnici.Items.Add(item.KorisnickoIme);
            }

            ObrisiStareRezervacije();

        }

        public static void ObrisiStareRezervacije()
        {
            List<Rezervacija> rezervacije = new List<Rezervacija>();
            using (var context = new Entities_db1())
            {
                DateTime datum = DateTime.Today.AddDays(-3);
                DateTime defaultDatum = DateTime.MinValue;
                Console.WriteLine(defaultDatum);
                var query = (from r in context.Reservations
                             where r.DateAvailable < datum && r.DateAvailable != defaultDatum
                             select new Rezervacija
                             {
                                 RezervacijaID = r.ReservationID,
                                 KorisnikID = r.UserID,
                                 IzdanjeID = r.PublishingID,
                                 DatumRezervacije = r.DateReserved,
                                 DatumDostupnosti = r.DateAvailable
                             });
                rezervacije = query.ToList();

            }
            string korEmail;
            foreach (Rezervacija rezervacija in rezervacije)
            {
                using (var context = new Entities_db1())
                {
                    var query = (from r in context.Reservations
                                 where r.ReservationID == rezervacija.RezervacijaID
                                 select r).FirstOrDefault();
                    int pomIzdanjeID = query.PublishingID;
                    context.Reservations.Remove(query);
                    context.SaveChanges();
                    
                    var izdanjeRezervirano = context.Publishings.FirstOrDefault(p => p.PublishingID == pomIzdanjeID);
                    var rezervacijaAktivna = context.Reservations.FirstOrDefault(r => r.PublishingID == pomIzdanjeID);
                    var korisnikRezervirao = context.LibraryUsers.FirstOrDefault(l => l.UserID == rezervacijaAktivna.UserID);
                    var knjiga = context.Books.First(b => b.ISBN == izdanjeRezervirano.ISBN);
                    rezervacijaAktivna.DateAvailable = DateTime.Today;

                    context.SaveChanges();

                    korEmail = korisnikRezervirao.Email;
                    MailMessage poruka;
                    SmtpClient smtp;
                    poruka = new MailMessage();

                    poruka.IsBodyHtml = true;

                    poruka.To.Add(new MailAddress(korEmail));

                    poruka.Subject = "bitBooks: knjiga " + knjiga.Name + " je dostupna";

                    poruka.From = new MailAddress("PIbitBooks@gmail.com");

                    poruka.Body = "Poštovani," + "<br>" +
                                   "Knjiga " + knjiga.Name + " je postala dostupna." +
                                   "Vaša rezervacija traje 3 dana, ukoliko ne posudite knjigu u ovom roku, Vaša rezervacija se briše i  omogućava" +
                                   " se drugim korisnicima posudba." + "<br>" +
                                   "bitBooks";


                    smtp = new SmtpClient();

                    smtp.Port = 587;

                    smtp.EnableSsl = true;

                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.UseDefaultCredentials = false;

                    smtp.Credentials = new NetworkCredential("PIbitBooks@gmail.com", "bitBooksPI");

                    smtp.Host = "smtp.gmail.com";

                    smtp.EnableSsl = true;

                    smtp.Send(poruka);

                    
                }
            }
        }

        private void dgvKnjige_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvKnjige.SelectedRows.Count != 0)
            {
                Knjiga knjiga = dgvKnjige.SelectedRows[0].DataBoundItem as Knjiga;
                label7.Text = knjiga.Ime;
                label2.Text = knjiga.GodinaPisanja.ToString();

                List<Žanr> zanr = new List<Žanr>();

                using (var context = new Entities_db1())
                {
                    var query = from g in context.Genres
                                where g.GenreID == knjiga.ŽanrID
                                select new Žanr
                                {
                                    ŽanrID = g.GenreID,
                                    Ime = g.Name
                                };
                    zanr = query.ToList();
                }

                label6.Text = zanr[0].Ime;

                List<Autor> autori = new List<Autor>();

                using (var context = new Entities_db1())
                {
                    var query = from w in context.Wrotes
                                join a in context.Authors on w.AuthorID equals a.AuthorID
                                join b in context.Books on w.ISBN equals b.ISBN
                                where w.ISBN == knjiga.ISBN
                                select new Autor
                                {
                                    AutorID = a.AuthorID,
                                    Ime = a.Name,
                                    Prezime = a.Surname,
                                    Drzava = a.Country
                                };
                    autori = query.ToList();
                }

                string imenaAutora = null;
                foreach(Autor item in autori)
                {
                    imenaAutora = imenaAutora + item.Ime + ' ' + item.Prezime + '\n';
                }

                autoriLabel.Text = imenaAutora;
                string fileName = knjiga.ISBN;

                var slika = Properties.Resources.ResourceManager.GetObject(fileName, Properties.Resources.Culture) as Image;
                pictureBox1.Image = slika;
                pictureBox1.Refresh();

                List<Korisnik> korisniciPosudbe = new List<Korisnik>();
                List<Korisnik> korisniciRezervacije = new List<Korisnik>();
                using (var context = new Entities_db1())
                {
                    var query = from l in context.Loans
                                join u in context.LibraryUsers on l.UserID equals u.UserID
                                join p in context.Publishings on l.PublishingID equals p.PublishingID
                                where p.ISBN == knjiga.ISBN && l.LoanStatus == "Posudena" && u.LibraryID == Sesija.Korisnik.KnjiznicaID
                                select new Korisnik
                                {
                                    KorisnikID = u.UserID,
                                    ImeTipa = u.UserType.Name,
                                    KnjiznicaID = u.LibraryID,
                                    ImeKnjiznice = u.Library.Name,
                                    Email = u.Email,
                                    Adresa = u.Adress,
                                    KorisnickoIme = u.Username,
                                    Ime = u.Name,
                                    Prezime = u.Surname,
                                };
                    korisniciPosudbe = query.ToList();

                    var query1 = from r in context.Reservations
                                join u in context.LibraryUsers on r.UserID equals u.UserID
                                join p in context.Publishings on r.PublishingID equals p.PublishingID
                                where p.ISBN == knjiga.ISBN && u.LibraryID == Sesija.Korisnik.KnjiznicaID
                                select new Korisnik
                                {
                                    KorisnikID = u.UserID,
                                    ImeTipa = u.UserType.Name,
                                    KnjiznicaID = u.LibraryID,
                                    ImeKnjiznice = u.Library.Name,
                                    Email = u.Email,
                                    Adresa = u.Adress,
                                    KorisnickoIme = u.Username,
                                    Ime = u.Name,
                                    Prezime = u.Surname,
                                };
                    korisniciRezervacije = query1.ToList();

                }
                dgvKorisnici.DataSource = korisniciPosudbe;
                dgvRezervacije.DataSource = korisniciRezervacije;
                dgvIzdanja.DataSource = Izdanje.DohvatiIzdanjaKnjige(knjiga.ISBN);
            }
            
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if(searchBox.Text != null)
            {
                List<Knjiga> pretrazivanje = Knjiga.DohvatiKnjige();
                List<Knjiga> output = new List<Knjiga>();
                int brojSlova = searchBox.Text.Length;
                if(cmbPretrazivanje.SelectedItem.ToString() == "ISBN")
                {
                    foreach (Knjiga knjiga in pretrazivanje)
                    {
                        if (knjiga.ISBN.Length > brojSlova)
                        {
                            if (knjiga.ISBN.Substring(0, brojSlova) == searchBox.Text)
                            {
                                output.Add(knjiga);
                            }
                        }
                        else
                        {
                            if (knjiga.ISBN == searchBox.Text)
                            {
                                output.Add(knjiga);
                            }
                        }

                    }
                }
                else
                {
                    foreach (Knjiga knjiga in pretrazivanje)
                    {
                        if (knjiga.Ime.Length > brojSlova)
                        {
                            if (knjiga.Ime.Substring(0, brojSlova) == searchBox.Text)
                            {
                                output.Add(knjiga);
                            }
                        }
                        else
                        {
                            if (knjiga.Ime == searchBox.Text)
                            {
                                output.Add(knjiga);
                            }
                        }

                    }
                }
                
                dgvKnjige.DataSource = output;
            }
            else
            {
                dgvKnjige.DataSource = Knjiga.DohvatiKnjige();
            }
            
        }

        private void btnNaljepnica_Click(object sender, EventArgs e)
        {
            if (dgvIzdanja.SelectedRows.Count == 0) return;
            printPreviewNaljepnica.ShowDialog();
        }

        private void printNaljepnica_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Izdanje izdanje = dgvIzdanja.CurrentRow.DataBoundItem as Izdanje;

            List<Knjiga> knjiga = new List<Knjiga>();

            using (var context = new Entities_db1())
            {
                var query = from b in context.Books
                            where b.ISBN == izdanje.ISBN
                            select new Knjiga
                            {
                                ISBN = b.ISBN,
                                Ime = b.Name,
                                ŽanrID = b.GenreID,
                                GodinaPisanja = b.YearWritten
                            };
                knjiga = query.ToList();
            }

            BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };

            Bitmap bmp;

            bmp = writer.Write(izdanje.ISBN + "#" + izdanje.IzdanjeID.ToString());

            int x = 50;
            int y = 20;

            for(int i = 0; i<(int)cmbBrojNaljepnica.SelectedItem; i=i+2)
            {
                e.Graphics.DrawImage(bmp, x, y);
                e.Graphics.DrawString(knjiga[0].Ime, new Font("Arial", 12), new SolidBrush(Color.Black), x, y+110);
                e.Graphics.DrawString(izdanje.GodinaIzdavanja.ToString(), new Font("Arial", 12), new SolidBrush(Color.Black), x, y + 130);
                e.Graphics.DrawString(Sesija.Korisnik.ImeKnjiznice, new Font("Arial", 12), new SolidBrush(Color.Black), x, y + 160);
                
                e.Graphics.DrawImage(bmp, x, y);
                e.Graphics.DrawString(knjiga[0].Ime, new Font("Arial", 12), new SolidBrush(Color.Black), x, y + 110);
                e.Graphics.DrawString(izdanje.GodinaIzdavanja.ToString(), new Font("Arial", 12), new SolidBrush(Color.Black), x, y + 130);
                e.Graphics.DrawString(Sesija.Korisnik.ImeKnjiznice, new Font("Arial", 12), new SolidBrush(Color.Black), x, y + 160);

                y += 300;
            }
            x = 400;
            y = 20;
            for (int i = 1; i < (int)cmbBrojNaljepnica.SelectedItem; i = i + 2)
            {
                e.Graphics.DrawImage(bmp, x, y);
                e.Graphics.DrawString(knjiga[0].Ime, new Font("Arial", 12), new SolidBrush(Color.Black), x, y + 110);
                e.Graphics.DrawString(izdanje.GodinaIzdavanja.ToString(), new Font("Arial", 12), new SolidBrush(Color.Black), x, y + 130);
                e.Graphics.DrawString(Sesija.Korisnik.ImeKnjiznice, new Font("Arial", 12), new SolidBrush(Color.Black), x, y + 160);

                e.Graphics.DrawImage(bmp, x, y);
                e.Graphics.DrawString(knjiga[0].Ime, new Font("Arial", 12), new SolidBrush(Color.Black), x, y + 110);
                e.Graphics.DrawString(izdanje.GodinaIzdavanja.ToString(), new Font("Arial", 12), new SolidBrush(Color.Black), x, y + 130);
                e.Graphics.DrawString(Sesija.Korisnik.ImeKnjiznice, new Font("Arial", 12), new SolidBrush(Color.Black), x, y + 160);

                y += 300;
            }
        }

        private void btnSkeniraj_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            Knjiga knjiga;
            Izdanje izdanje;
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                dgvKnjige.Invoke(new MethodInvoker(delegate ()
                {
                    string rezultat = result.ToString();
                    string[] splitaniRezultat = rezultat.Split('#');
                    string ISBN = splitaniRezultat[0];
                    int izdanjeID = int.Parse(splitaniRezultat[1]);
                    foreach (DataGridViewRow row in dgvKnjige.Rows)
                    {
                        knjiga = row.DataBoundItem as Knjiga;
                        if (knjiga.ISBN == ISBN)
                        {
                            row.Selected = true;
                        }
                        else
                        {
                            row.Selected = false;
                        }
                    }
                    foreach (DataGridViewRow row in dgvIzdanja.Rows)
                    {
                        izdanje = row.DataBoundItem as Izdanje;
                        if (izdanje.IzdanjeID == izdanjeID)
                        {
                            row.Selected = true;
                        }
                        else
                        {
                            row.Selected = false;
                        }
                    }
                }));
            }
        }

        private void PregledKnjigaZaposlenikForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(videoCaptureDevice != null)
            {
                videoCaptureDevice.Stop();
            }
        }

        private void btnPosudi_Click(object sender, EventArgs e)
        {
            if (cmbKorisnici.SelectedItem != null)
            {

                Korisnik korisnik = Korisnik.DohvatiKorisnikaPoKorisnickomImenu(cmbKorisnici.SelectedItem.ToString());

                foreach(DataGridViewRow row in dgvKorisnici.Rows)
                {
                    Korisnik pomocni = row.DataBoundItem as Korisnik;
                    if(pomocni.KorisnikID == korisnik.KorisnikID)
                    {
                        MessageBox.Show("Korisnik je već posudio tu knjigu.");
                        return;
                    }
                }

                List<Posudba> posudbe = Posudba.DohvatiPosudbeKorisnika(korisnik.KorisnikID);
                int i = 0;
                foreach(Posudba item in posudbe)
                {
                    if(item.StatusPosudbe == "Posudena")
                    {
                        i++;
                    }
                }
                if(i>2)
                {
                    MessageBox.Show("Korisnik ima 3 posudbe.");
                    return;
                }

                Izdanje izdanje = dgvIzdanja.CurrentRow.DataBoundItem as Izdanje;

                bool postojiRezervacija = false;
                Korisnik korisnikRezervirao = new Korisnik();
                foreach(DataGridViewRow row in dgvRezervacije.Rows)
                {
                    postojiRezervacija = true;
                    korisnikRezervirao = row.DataBoundItem as Korisnik;
                    if (korisnikRezervirao.KorisnickoIme == cmbKorisnici.SelectedItem.ToString())
                    {
                        break;
                    }
                }

                if (izdanje.BrojDostupnih != 0)
                {
                    if (!postojiRezervacija || izdanje.BrojDostupnih > 1 || korisnikRezervirao.KorisnickoIme == cmbKorisnici.SelectedItem.ToString())
                    {
                        using (var context = new Entities_db1())
                        {

                            Loan posudba = new Loan();

                            posudba.UserID = korisnik.KorisnikID;
                            posudba.PublishingID = izdanje.IzdanjeID;
                            posudba.DueDate = DateTime.Today.AddDays(14);
                            posudba.LoanStatus = "Posudena";
                            context.Loans.Add(posudba);
                            context.SaveChanges();

                            var izdanje2 = context.Publishings.First(p => p.PublishingID == izdanje.IzdanjeID);
                            izdanje2.NumLoaned++;
                            izdanje2.NumAvailable--;
                            context.SaveChanges();
                        }
                        if(korisnikRezervirao.KorisnickoIme == cmbKorisnici.SelectedItem.ToString())
                        {
                            using (var context = new Entities_db1())
                            {
                                var query = (from r in context.Reservations
                                             where r.UserID == korisnikRezervirao.KorisnikID && r.PublishingID == izdanje.IzdanjeID
                                             select r).FirstOrDefault();
                                context.Reservations.Remove(query);
                                context.SaveChanges();

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Postoji rezervacija.");
                    }
                }
                else
                {
                    
                    MessageBox.Show("Nema dostupnog izdanja.");
                }
            }



            RefreshPosudbeRezervacije();
        }

        private void btnVrati_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = dgvKorisnici.CurrentRow.DataBoundItem as Korisnik;
            Knjiga knjiga = dgvKnjige.CurrentRow.DataBoundItem as Knjiga;
            List<Izdanje> izdanja = Izdanje.DohvatiIzdanjaKnjige(knjiga.ISBN);
            List<Posudba> posudbe = Posudba.DohvatiPosudbeKorisnika(korisnik.KorisnikID);
            int pomIzdanjeID = 0;
            foreach (Posudba posudba in posudbe)
            {
                foreach (Izdanje izdanje in izdanja)
                {
                    if (posudba.IzdanjeID == izdanje.IzdanjeID && posudba.StatusPosudbe != "Vracena")
                    {
                        using (var context = new Entities_db1())
                        {
                            {
                                var posudba2 = context.Loans.First(l => l.LoanID == posudba.PosudbaID);
                                posudba2.LoanStatus = "Vracena";
                                context.SaveChanges();
                                var izdanje2 = context.Publishings.First(p => p.PublishingID == izdanje.IzdanjeID);
                                izdanje2.NumLoaned--;
                                izdanje2.NumAvailable++;
                                pomIzdanjeID = izdanje2.PublishingID;
                                context.SaveChanges();
                            }
                        }

                    }
                }
            }
               
            RefreshPosudbeRezervacije();

            bool postoji = false;
            using (var context = new Entities_db1())
            {
                {
                    if(context.Reservations.Any(r => r.PublishingID == pomIzdanjeID))
                    {
                        postoji = true;
                    }
                }
            }
            if (postoji)
            {
                
                string korEmail;
                using (var context = new Entities_db1())
                {
                    var rezervacija = context.Reservations.First(r => r.PublishingID == pomIzdanjeID);
                    var korisnikRezervirao = context.LibraryUsers.First(l => l.UserID == rezervacija.UserID);
                    rezervacija.DateAvailable = DateTime.Today;
                    context.SaveChanges();
                    korEmail = korisnikRezervirao.Email;
                    MailMessage poruka;
                    SmtpClient smtp;
                    poruka = new MailMessage();

                    poruka.IsBodyHtml = true;

                    poruka.To.Add(new MailAddress(korEmail));

                    poruka.Subject = "bitBooks: knjiga " + knjiga.Ime + " je dostupna";

                    poruka.From = new MailAddress("PIbitBooks@gmail.com");

                    poruka.Body = "Poštovani," + "<br>" +
                                   "Knjiga " + knjiga.Ime + " je postala dostupna." +
                                   "Vaša rezervacija traje 3 dana, ukoliko ne posudite knjigu u ovom roku, Vaša rezervacija se briše i  omogućava" +
                                   " se drugim korisnicima posudba." + "<br>" +
                                   "bitBooks";


                    smtp = new SmtpClient();

                    smtp.Port = 587;

                    smtp.EnableSsl = true;

                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.UseDefaultCredentials = false;

                    smtp.Credentials = new NetworkCredential("PIbitBooks@gmail.com", "bitBooksPI");

                    smtp.Host = "smtp.gmail.com";

                    smtp.EnableSsl = true;

                    smtp.Send(poruka);

                    smtp.SendCompleted += new SendCompletedEventHandler(smtp_SendCompleted);
                }
                
            }

                
        }

        private void RefreshPosudbeRezervacije()
        {
            Knjiga knjiga = dgvKnjige.CurrentRow.DataBoundItem as Knjiga;
            List<Korisnik> korisniciPosudbe = new List<Korisnik>();
            List<Korisnik> korisniciRezervacije = new List<Korisnik>();
            using (var context = new Entities_db1())
            {
                var query = from l in context.Loans
                            join u in context.LibraryUsers on l.UserID equals u.UserID
                            join p in context.Publishings on l.PublishingID equals p.PublishingID
                            where p.ISBN == knjiga.ISBN && l.LoanStatus == "Posudena" && u.LibraryID == Sesija.Korisnik.KnjiznicaID
                            select new Korisnik
                            {
                                KorisnikID = u.UserID,
                                ImeTipa = u.UserType.Name,
                                KnjiznicaID = u.LibraryID,
                                ImeKnjiznice = u.Library.Name,
                                Email = u.Email,
                                Adresa = u.Adress,
                                KorisnickoIme = u.Username,
                                Ime = u.Name,
                                Prezime = u.Surname,
                            };
                korisniciPosudbe = query.ToList();

                var query1 = from r in context.Reservations
                             join u in context.LibraryUsers on r.UserID equals u.UserID
                             join p in context.Publishings on r.PublishingID equals p.PublishingID
                             where p.ISBN == knjiga.ISBN && u.LibraryID == Sesija.Korisnik.KnjiznicaID
                             select new Korisnik
                             {
                                 KorisnikID = u.UserID,
                                 ImeTipa = u.UserType.Name,
                                 KnjiznicaID = u.LibraryID,
                                 ImeKnjiznice = u.Library.Name,
                                 Email = u.Email,
                                 Adresa = u.Adress,
                                 KorisnickoIme = u.Username,
                                 Ime = u.Name,
                                 Prezime = u.Surname,
                             };
                korisniciRezervacije = query1.ToList();

            }
            dgvKorisnici.DataSource = korisniciPosudbe;
            dgvRezervacije.DataSource = korisniciRezervacije;
            dgvIzdanja.DataSource = Izdanje.DohvatiIzdanjaKnjige(knjiga.ISBN);
        }

        private void btnOtkaziRez_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = dgvRezervacije.CurrentRow.DataBoundItem as Korisnik;
            Knjiga knjiga = dgvKnjige.CurrentRow.DataBoundItem as Knjiga;
            List<Izdanje> izdanja = Izdanje.DohvatiIzdanjaKnjige(knjiga.ISBN);
            List<Rezervacija> rezervacije = Rezervacija.DohvatiRezervacijeKorisnika(korisnik.KorisnikID);
            foreach (Rezervacija rezervacija in rezervacije)
            {
                foreach (Izdanje izdanje in izdanja)
                {
                    if (rezervacija.IzdanjeID == izdanje.IzdanjeID)
                    {
                        using (var context = new Entities_db1())
                        {
                            var query = (from r in context.Reservations
                                         where r.ReservationID == rezervacija.RezervacijaID
                                         select r).FirstOrDefault();
                            context.Reservations.Remove(query);
                            context.SaveChanges();

                        }

                    }
                }

            }

            RefreshPosudbeRezervacije();
        }

        void smtp_SendCompleted(object sender, AsyncCompletedEventArgs e)

        {

            if (e.Cancelled == true)

            {

                MessageBox.Show("Email sending cancelled!");

            }

            else if (e.Error != null)

            {

                MessageBox.Show(e.Error.Message);

            }

            else

            {

                MessageBox.Show("Email sent sucessfully!");

            }

        }
    }
}
