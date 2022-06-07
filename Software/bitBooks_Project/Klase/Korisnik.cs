using Aspose.Pdf;
using Aspose.Pdf.Drawing;
using Aspose.Pdf.Facades;
using Aspose.Pdf.Text;
using bitBooks_Project.Dorian_Iznimke;
using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;

namespace bitBooks_Project.Klase
{
    public class Korisnik
    {
        public int KorisnikID { get; set; }
        public int TipID { get; set; }
        public string ImeTipa { get; set; }
        public int? KnjiznicaID { get; set; }
        public string ImeKnjiznice { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string AktivacijskiKod { get; set; }
        public DateTime DatumRegistracije { get; set; }

        public static List<Korisnik> DohvatiSveKorisnike()
        {
            List<Korisnik> sviKorisnici = new List<Korisnik>();

            using (var context = new Entities_db1())
            {
                var query = from l in context.LibraryUsers
                            select new Korisnik
                            {
                                KorisnikID = l.UserID,
                                TipID = l.TypeID,
                                ImeTipa = l.UserType.Name,
                                KnjiznicaID = l.LibraryID,
                                ImeKnjiznice = l.Library.Name,
                                Email = l.Email,
                                Adresa = l.Adress,
                                KorisnickoIme = l.Username,
                                Lozinka = l.Password,
                                Ime = l.Name,
                                Prezime = l.Surname,
                                AktivacijskiKod = l.ActivationCode,
                                DatumRegistracije = l.DateTimeRegistration
                            };

                sviKorisnici = query.ToList();
            }

            return sviKorisnici;
        }

        public static List<Korisnik> DohvatiSveKorisnike(int superadminID)
        {
            List<Korisnik> sviKorisnici = new List<Korisnik>();

            using (var context = new Entities_db1())
            {
                var query = from l in context.LibraryUsers
                            where l.UserID != superadminID
                            select new Korisnik
                            {
                                KorisnikID = l.UserID,
                                TipID = l.TypeID,
                                ImeTipa = l.UserType.Name,
                                KnjiznicaID = l.LibraryID,
                                ImeKnjiznice = l.Library.Name,
                                Email = l.Email,
                                Adresa = l.Adress,
                                KorisnickoIme = l.Username,
                                Lozinka = l.Password,
                                Ime = l.Name,
                                Prezime = l.Surname,
                                AktivacijskiKod = l.ActivationCode,
                                DatumRegistracije = l.DateTimeRegistration
                            };

                sviKorisnici = query.ToList();
            }

            return sviKorisnici;
        }

        public static List<Korisnik> DohvatiSveZaposlenike()
        {
            List<Korisnik> sviKorisnici = new List<Korisnik>();

            using (var context = new Entities_db1())
            {
                var query = from l in context.LibraryUsers
                            where l.TypeID == 3
                            select new Korisnik
                            {
                                KorisnikID = l.UserID,
                                TipID = l.TypeID,
                                ImeTipa = l.UserType.Name,
                                KnjiznicaID = l.LibraryID,
                                ImeKnjiznice = l.Library.Name,
                                Email = l.Email,
                                Adresa = l.Adress,
                                KorisnickoIme = l.Username,
                                Lozinka = l.Password,
                                Ime = l.Name,
                                Prezime = l.Surname,
                                AktivacijskiKod = l.ActivationCode,
                                DatumRegistracije = l.DateTimeRegistration
                            };

                sviKorisnici = query.ToList();
            }

            return sviKorisnici;
        }

        public static List<Korisnik> DohvatiKorisnikeKnjižnice(int? knjiznicaID)
        {
            List<Korisnik> korisniciKnjiznice = new List<Korisnik>();

            using (var context = new Entities_db1())
            {
                var query = from l in context.LibraryUsers
                            where l.LibraryID == knjiznicaID
                            select new Korisnik
                            {
                                KorisnikID = l.UserID,
                                TipID = l.TypeID,
                                ImeTipa = l.UserType.Name,
                                KnjiznicaID = l.LibraryID,
                                ImeKnjiznice = l.Library.Name,
                                Email = l.Email,
                                Adresa = l.Adress,
                                KorisnickoIme = l.Username,
                                Lozinka = l.Password,
                                Ime = l.Name,
                                Prezime = l.Surname,
                                AktivacijskiKod = l.ActivationCode,
                                DatumRegistracije = l.DateTimeRegistration
                            };
                korisniciKnjiznice = query.ToList();
            }

            return korisniciKnjiznice;
        }

        public static List<Korisnik> DohvatiZaposlenikeKnjižnice(int? knjiznicaID)
        {
            List<Korisnik> zaposleniciKnjiznice = new List<Korisnik>();

            using (var context = new Entities_db1())
            {
                var query = from l in context.LibraryUsers
                            where l.LibraryID == knjiznicaID && l.UserType.Name == "Zaposlenik"
                            select new Korisnik
                            {
                                KorisnikID = l.UserID,
                                TipID = l.TypeID,
                                ImeTipa = l.UserType.Name,
                                KnjiznicaID = l.LibraryID,
                                ImeKnjiznice = l.Library.Name,
                                Email = l.Email,
                                Adresa = l.Adress,
                                KorisnickoIme = l.Username,
                                Lozinka = l.Password,
                                Ime = l.Name,
                                Prezime = l.Surname,
                                AktivacijskiKod = l.ActivationCode,
                                DatumRegistracije = l.DateTimeRegistration
                            };
                zaposleniciKnjiznice = query.ToList();
            }

            return zaposleniciKnjiznice;
        }

        public static Korisnik DohvatiKorisnikaPoID(int korisnikID)
        {
            Korisnik korisnik;

            using (var context = new Entities_db1())
            {
                var query = from l in context.LibraryUsers
                            where l.UserID == korisnikID
                            select new Korisnik
                            {
                                KorisnikID = l.UserID,
                                TipID = l.TypeID,
                                ImeTipa = l.UserType.Name,
                                KnjiznicaID = l.LibraryID,
                                ImeKnjiznice = l.Library.Name,
                                Email = l.Email,
                                Adresa = l.Adress,
                                KorisnickoIme = l.Username,
                                Lozinka = l.Password,
                                Ime = l.Name,
                                Prezime = l.Surname,
                                AktivacijskiKod = l.ActivationCode,
                                DatumRegistracije = l.DateTimeRegistration
                            };
                korisnik = query.Single();
            }

            return korisnik;
        }

        public string DohvatiTipKorisnika(Korisnik korisnik)
        {
            string tipKorisnika;
            using (var context = new Entities_db1())
            {
                var query = from u in context.UserTypes
                            where u.TypeID == korisnik.TipID
                            select u.Name;

                tipKorisnika = query.Single();
            }

            return tipKorisnika;
        }

        public static List<Korisnik> DohvatiKorisnikaPoImenu(string ime, int? knjiznicaID)
        {
            List<Korisnik> korisniciImena = new List<Korisnik>();
            using (var context = new Entities_db1())
            {
                var query = from l in context.LibraryUsers
                            where l.Name.Contains(ime) && l.LibraryID == knjiznicaID
                            select new Korisnik
                            {
                                KorisnikID = l.UserID,
                                TipID = l.TypeID,
                                ImeTipa = l.UserType.Name,
                                KnjiznicaID = l.LibraryID,
                                ImeKnjiznice = l.Library.Name,
                                Email = l.Email,
                                Adresa = l.Adress,
                                KorisnickoIme = l.Username,
                                Lozinka = l.Password,
                                Ime = l.Name,
                                Prezime = l.Surname,
                                AktivacijskiKod = l.ActivationCode,
                                DatumRegistracije = l.DateTimeRegistration
                            };
                korisniciImena = query.ToList();
            }

            return korisniciImena;
        }

        public static List<Korisnik> DohvatiKorisnikaPoPrezimenu(string prezime, int? knjiznicaID)
        {
            List<Korisnik> korisniciPrezimena = new List<Korisnik>();
            using (var context = new Entities_db1())
            {
                var query = from l in context.LibraryUsers
                            where l.Surname.Contains(prezime) && l.LibraryID == knjiznicaID
                            select new Korisnik
                            {
                                KorisnikID = l.UserID,
                                TipID = l.TypeID,
                                ImeTipa = l.UserType.Name,
                                KnjiznicaID = l.LibraryID,
                                ImeKnjiznice = l.Library.Name,
                                Email = l.Email,
                                Adresa = l.Adress,
                                KorisnickoIme = l.Username,
                                Lozinka = l.Password,
                                Ime = l.Name,
                                Prezime = l.Surname,
                                AktivacijskiKod = l.ActivationCode,
                                DatumRegistracije = l.DateTimeRegistration
                            };
                korisniciPrezimena = query.ToList();
            }

            return korisniciPrezimena;
        }

        public static List<Korisnik> DohvatiPoImenuIPrezimenu(string ime, string prezime, int? knjiznicaID)
        {
            List<Korisnik> korisniciImePrezime = new List<Korisnik>();
            using (var context = new Entities_db1())
            {
                var query = from l in context.LibraryUsers
                            where l.Name.Contains(ime) && l.Surname.Contains(prezime) && l.LibraryID == knjiznicaID
                            select new Korisnik
                            {
                                KorisnikID = l.UserID,
                                TipID = l.TypeID,
                                ImeTipa = l.UserType.Name,
                                KnjiznicaID = l.LibraryID,
                                ImeKnjiznice = l.Library.Name,
                                Email = l.Email,
                                Adresa = l.Adress,
                                KorisnickoIme = l.Username,
                                Lozinka = l.Password,
                                Ime = l.Name,
                                Prezime = l.Surname,
                                AktivacijskiKod = l.ActivationCode,
                                DatumRegistracije = l.DateTimeRegistration
                            };
                korisniciImePrezime = query.ToList();
            }

            return korisniciImePrezime;
        }

        public static List<Korisnik> DohvatiKorisnikaPoImenuSA(string ime)
        {
            List<Korisnik> korisniciImena = new List<Korisnik>();
            using (var context = new Entities_db1())
            {
                var query = from l in context.LibraryUsers
                            where l.Name.Contains(ime)
                            select new Korisnik
                            {
                                KorisnikID = l.UserID,
                                TipID = l.TypeID,
                                ImeTipa = l.UserType.Name,
                                KnjiznicaID = l.LibraryID,
                                ImeKnjiznice = l.Library.Name,
                                Email = l.Email,
                                Adresa = l.Adress,
                                KorisnickoIme = l.Username,
                                Lozinka = l.Password,
                                Ime = l.Name,
                                Prezime = l.Surname,
                                AktivacijskiKod = l.ActivationCode,
                                DatumRegistracije = l.DateTimeRegistration
                            };
                korisniciImena = query.ToList();
            }

            return korisniciImena;
        }

        public static List<Korisnik> DohvatiKorisnikaPoPrezimenuSA(string prezime)
        {
            List<Korisnik> korisniciPrezimena = new List<Korisnik>();
            using (var context = new Entities_db1())
            {
                var query = from l in context.LibraryUsers
                            where l.Surname.Contains(prezime)
                            select new Korisnik
                            {
                                KorisnikID = l.UserID,
                                TipID = l.TypeID,
                                ImeTipa = l.UserType.Name,
                                KnjiznicaID = l.LibraryID,
                                ImeKnjiznice = l.Library.Name,
                                Email = l.Email,
                                Adresa = l.Adress,
                                KorisnickoIme = l.Username,
                                Lozinka = l.Password,
                                Ime = l.Name,
                                Prezime = l.Surname,
                                AktivacijskiKod = l.ActivationCode,
                                DatumRegistracije = l.DateTimeRegistration
                            };
                korisniciPrezimena = query.ToList();
            }

            return korisniciPrezimena;
        }

        public static List<Korisnik> DohvatiPoImenuIPrezimenuSA(string ime, string prezime)
        {
            List<Korisnik> korisniciImePrezime = new List<Korisnik>();
            using (var context = new Entities_db1())
            {
                var query = from l in context.LibraryUsers
                            where l.Name.Contains(ime) && l.Surname.Contains(prezime)
                            select new Korisnik
                            {
                                KorisnikID = l.UserID,
                                TipID = l.TypeID,
                                ImeTipa = l.UserType.Name,
                                KnjiznicaID = l.LibraryID,
                                ImeKnjiznice = l.Library.Name,
                                Email = l.Email,
                                Adresa = l.Adress,
                                KorisnickoIme = l.Username,
                                Lozinka = l.Password,
                                Ime = l.Name,
                                Prezime = l.Surname,
                                AktivacijskiKod = l.ActivationCode,
                                DatumRegistracije = l.DateTimeRegistration
                            };
                korisniciImePrezime = query.ToList();
            }

            return korisniciImePrezime;
        }
        public override string ToString()
        {
            return Ime + " " + Prezime;
        }

        public static Korisnik DohvatiKorisnikaPoKorisnickomImenu(string korime)
        {
            Korisnik korisnik = new Korisnik();
            using (var context = new Entities_db1())
            {
                var query = from l in context.LibraryUsers
                            where l.Username == korime
                            select new Korisnik
                            {
                                KorisnikID = l.UserID,
                                TipID = l.TypeID,
                                ImeTipa = l.UserType.Name,
                                KnjiznicaID = l.LibraryID,
                                ImeKnjiznice = l.Library.Name,
                                Email = l.Email,
                                Adresa = l.Adress,
                                KorisnickoIme = l.Username,
                                Lozinka = l.Password,
                                Ime = l.Name,
                                Prezime = l.Surname,
                                AktivacijskiKod = l.ActivationCode,
                                DatumRegistracije = l.DateTimeRegistration
                            };
                korisnik = query.ToList()[0];
            }

            return korisnik;
        }

        public static bool ProvjeriLozinku(string korime, string lozinka)
        {
            using (var context = new Entities_db1())
            {
                var query = from l in context.LibraryUsers
                            where l.Username == korime
                            select new Korisnik
                            {
                                KorisnikID = l.UserID,
                                TipID = l.TypeID,
                                ImeTipa = l.UserType.Name,
                                KnjiznicaID = l.LibraryID,
                                ImeKnjiznice = l.Library.Name,
                                Email = l.Email,
                                Adresa = l.Adress,
                                KorisnickoIme = l.Username,
                                Lozinka = l.Password,
                                Ime = l.Name,
                                Prezime = l.Surname,
                                AktivacijskiKod = l.ActivationCode,
                                DatumRegistracije = l.DateTimeRegistration
                            };
                if (query.SingleOrDefault() != null)
                {
                    if (query.ToList()[0].Lozinka == lozinka)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static Korisnik DohvatiKorisnikaPoEmailu(string email)
        {
            Korisnik korisnik;

            using (var context = new Entities_db1())
            {
                var query = from l in context.LibraryUsers
                            where l.Email == email
                            select new Korisnik
                            {
                                KorisnikID = l.UserID,
                                TipID = l.TypeID,
                                ImeTipa = l.UserType.Name,
                                KnjiznicaID = l.LibraryID,
                                ImeKnjiznice = l.Library.Name,
                                Email = l.Email,
                                Adresa = l.Adress,
                                KorisnickoIme = l.Username,
                                Lozinka = l.Password,
                                Ime = l.Name,
                                Prezime = l.Surname,
                                AktivacijskiKod = l.ActivationCode,
                                DatumRegistracije = l.DateTimeRegistration
                            };
                try
                {
                    korisnik = query.First();
                }
                catch
                {
                    korisnik = null;
                }

            }

            return korisnik;
        }

        public void ObrisiKorisnika()
        {
            if(Sesija.Korisnik.TipID == 3)
            {
                ValidacijaBrisanja();
            }
            using (var context = new Entities_db1())
            {
                var query = (from l in context.LibraryUsers
                             where l.UserID == KorisnikID
                             select l).FirstOrDefault();
                context.LibraryUsers.Remove(query);
                context.SaveChanges();

            }
        }

        private  void ValidacijaBrisanja()
        {
            if (TipID == 1 || TipID == 2)
            {
                throw new AdminException("Ne možete brisati admina iz baze!");
            }
        }

        public static int DohvatiBrojPosudbi(int korisnikID)
        {          
            List<Posudba> pos = new List<Posudba>();
            
            using (var context = new Entities_db1())
            {
                var query = from l in context.Loans
                            join u in context.LibraryUsers
                            on l.UserID equals u.UserID
                            where l.LoanStatus == "Posudena"
                            select new Posudba
                            {
                                PosudbaID = l.LoanID,
                                KorisnikID = l.UserID,
                                IzdanjeID = l.PublishingID,
                                DatumPovratka = l.DueDate,
                                StatusPosudbe = l.LoanStatus
                            };

                pos = query.ToList();
            }
            int i = 0;
            foreach(Posudba item in pos)
            {
                if (korisnikID == item.KorisnikID) i++;              
            }
            using (var context = new Entities_db1())
            {
                var query = from l in context.Loans
                            join u in context.LibraryUsers
                            on l.UserID equals u.UserID
                            where l.LoanStatus == "Zakasnjela"
                            select new Posudba
                            {
                                PosudbaID = l.LoanID,
                                KorisnikID = l.UserID,
                                IzdanjeID = l.PublishingID,
                                DatumPovratka = l.DueDate,
                                StatusPosudbe = l.LoanStatus
                            };

                pos = query.ToList();
            }           
            foreach (Posudba item in pos)
            {
                if (korisnikID == item.KorisnikID) i++;
            }

            return i;

        }
        public static LibraryUser NoviAdmin(string email, string adress,string username, string password, string name, string surname)
        {
            ValidirajAdminUnos(email, adress, username, password, name, surname);
            using (var context = new Entities_db1())
            {

                LibraryUser admin = new LibraryUser();

                admin.TypeID = 2;
                admin.Email = email;
                admin.Adress = adress;
                admin.Username = username;
                admin.Password = password;
                admin.Name = name;
                admin.Surname = surname;
                admin.ActivationCode = GenerirajRandomActivationCode();
                admin.DateTimeRegistration = DateTime.Now;
                context.LibraryUsers.Add(admin);
                context.SaveChanges();
                return admin;
            }
        }

        public void AžurirajAdmina(int knjiznicaID)
        {
            using (var context = new Entities_db1())
            {
                var admin = context.LibraryUsers.First(l => l.UserID == KorisnikID);
                admin.LibraryID = knjiznicaID;
                context.SaveChanges();
            }
        }

        private static string GenerirajRandomActivationCode()
        {
            string kod="";
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                kod += random.Next(0,9);
            }
            return kod;
        }

        private static void  ValidirajAdminUnos(string email, string adresa, string user, string pw, string ime, string prezime)
        {
            if (email.Length > 50 || email.Length < 1 || adresa.Length > 50 || adresa.Length < 1 || ime.Length > 50 || ime.Length < 1 || prezime.Length > 50 || prezime.Length < 1 || user.Length > 20 || user.Length < 1 || pw.Length > 20 || pw.Length < 1)
            {
                throw new KorisnikException("Korisničko ime i lozinka smiju ima 20 znakova, a ostala polja do maksimalno 50!");
            }
        }
        public void GenerirajPDF()
        {
            string projectDirectory = Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName;

            Document document = new Document();
            Page page = document.Pages.Add();
            
            document.PageInfo.Height = 325;
            document.PageInfo.Width = 200;
            
            document.PageInfo.IsLandscape = true;

            MarginInfo marginInfo = new MarginInfo();
            marginInfo.Bottom = 0;
            marginInfo.Top = 50;
            marginInfo.Left = 50;

            document.PageInfo.Margin = marginInfo;

            TextFragment prazno = new TextFragment("");

            TextFragment user = new TextFragment("Korisničko ime: " + KorisnickoIme);
            user.VerticalAlignment = Aspose.Pdf.VerticalAlignment.Top;
            user.TextState.FontSize = 10;
            user.TextState.Font = FontRepository.FindFont("TimesNewRoman");
            user.TextState.FontStyle = FontStyles.Bold;
            page.Paragraphs.Add(user);
            page.Paragraphs.Add(prazno);

            TextFragment ime = new TextFragment("Ime: " + Ime);
            ime.VerticalAlignment = Aspose.Pdf.VerticalAlignment.Top;
            ime.TextState.FontSize = 10;
            ime.TextState.Font = FontRepository.FindFont("TimesNewRoman");
            ime.TextState.FontStyle = FontStyles.Bold;
            page.Paragraphs.Add(ime);
            page.Paragraphs.Add(prazno);

            TextFragment prezime = new TextFragment("Prezime: " + Prezime);
            prezime.VerticalAlignment = Aspose.Pdf.VerticalAlignment.Top;
            prezime.TextState.FontSize = 10;
            prezime.TextState.Font = FontRepository.FindFont("TimesNewRoman");
            prezime.TextState.FontStyle = FontStyles.Bold;
            page.Paragraphs.Add(prezime);
            page.Paragraphs.Add(prazno);

            TextFragment email = new TextFragment("Email: " + Email);
            email.VerticalAlignment = Aspose.Pdf.VerticalAlignment.Top;
            email.TextState.FontSize = 10;
            email.TextState.Font = FontRepository.FindFont("TimesNewRoman");
            email.TextState.FontStyle = FontStyles.Bold;
            page.Paragraphs.Add(email);
            page.Paragraphs.Add(prazno);

            TextFragment adresa = new TextFragment("Adresa: " + Adresa);
            adresa.VerticalAlignment = Aspose.Pdf.VerticalAlignment.Top;
            adresa.TextState.FontSize = 10;
            adresa.TextState.Font = FontRepository.FindFont("TimesNewRoman");
            adresa.TextState.FontStyle = FontStyles.Bold;
            page.Paragraphs.Add(adresa);
            page.Paragraphs.Add(prazno);

            TextFragment knj = new TextFragment("Knjižnica: " + ImeKnjiznice);
            knj.VerticalAlignment = Aspose.Pdf.VerticalAlignment.Top;
            knj.TextState.FontSize = 10;
            knj.TextState.Font = FontRepository.FindFont("TimesNewRoman");
            knj.TextState.FontStyle = FontStyles.Bold;
            page.Paragraphs.Add(knj);
            page.Paragraphs.Add(prazno);

            TextFragment proj = new TextFragment("bitBooks");
            proj.TextState.FontSize = 16;
            proj.TextState.Font = FontRepository.FindFont("TimesNewRoman");
            proj.TextState.FontStyle = FontStyles.Bold;
            page.Paragraphs.Add(proj);


            Aspose.Pdf.Rectangle rectangle = new Aspose.Pdf.Rectangle(20, 20, 120, 120);
            Aspose.Pdf.Rectangle barcode = new Aspose.Pdf.Rectangle(200, 70, 300, 170);
            page.AddImage(projectDirectory + "/Slike/knjigaB.png" , rectangle);

            //generiranje barkoda
            BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };

            Bitmap bmp;

            bmp = writer.Write(KorisnikID.ToString());

            bmp.Save(projectDirectory + "/PDF_Iskaznice/barkod.png", System.Drawing.Imaging.ImageFormat.Png);

            page.AddImage(projectDirectory + "/PDF_Iskaznice/barkod.png", barcode);

            document.Background = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.FromArgb(60, 179, 113));

            document.Save(projectDirectory + "/PDF_Iskaznice/" + KorisnickoIme +".pdf");
            Console.WriteLine(projectDirectory);
        }

        public static void NoviKorisnik(Korisnik korisnik)
        {
            using (var context = new Entities_db1())
            {
                LibraryUser libraryUser = new LibraryUser
                {
                    TypeID = korisnik.TipID,
                    LibraryID = korisnik.KnjiznicaID,
                    Email = korisnik.Email,
                    Adress = korisnik.Adresa,
                    Username = korisnik.KorisnickoIme,
                    Password = korisnik.Lozinka,
                    Name = korisnik.Ime,
                    Surname = korisnik.Prezime,
                    ActivationCode = korisnik.AktivacijskiKod,
                    DateTimeRegistration = korisnik.DatumRegistracije
                };

                context.LibraryUsers.Add(libraryUser);
                context.SaveChanges();
            }
        }

        public static void AžurirajKorisnika(Korisnik proslijeđenKorisnik)
        {
            using (var context = new Entities_db1())
            {
                LibraryUser libraryUser = context.LibraryUsers.First(x => x.UserID == proslijeđenKorisnik.KorisnikID);
                libraryUser.TypeID = proslijeđenKorisnik.TipID;
                libraryUser.LibraryID = proslijeđenKorisnik.KnjiznicaID;
                libraryUser.Email = proslijeđenKorisnik.Email;
                libraryUser.Adress = proslijeđenKorisnik.Adresa;
                libraryUser.Username = proslijeđenKorisnik.KorisnickoIme;
                libraryUser.Password = proslijeđenKorisnik.Lozinka;
                libraryUser.Name = proslijeđenKorisnik.Ime;
                libraryUser.Surname = proslijeđenKorisnik.Prezime;

                context.SaveChanges();
            }
        }
    }
}

