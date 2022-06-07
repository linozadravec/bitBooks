using bitBooks_Project.Dorian_Iznimke;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitBooks_Project.Klase
{
    class RecenzijaZaposlenika : Recenzija
    {
        public int ZaposlenikID { get; set; }
        public string ImeZaposlenika { get; set; }
        public string PrezimeZaposlenika { get; set; }
        public static int[] listaOcjena = new int[5] { 1, 2, 3, 4, 5 };
        public RecenzijaZaposlenika()
            : base()
        {

        }

        public static List<RecenzijaZaposlenika> DohvatiKorisnikoveRecenzijeZaposlenika(int korisnikID)
        {
            List<RecenzijaZaposlenika> korisnikoveRecenzije = new List<RecenzijaZaposlenika>();

            using (var context = new Entities_db1())
            {
                var query = from r in context.ReviewEmployees
                            where r.UserID == korisnikID
                            select new RecenzijaZaposlenika
                            {
                                RecenzijaID = r.ReviewEmployeeID,
                                ImeZaposlenika = r.LibraryUser.Name,
                                PrezimeZaposlenika = r.LibraryUser.Surname,
                                KorisnikID = r.UserID,
                                KorisnickoIme = r.LibraryUser1.Username,
                                TekstRecenzije = r.ReviewText,
                                Ocjena = r.Stars,
                                ZaposlenikID = r.EmployeeID,
                                DatumUnosa = r.EntryDate

                            };
                korisnikoveRecenzije = query.ToList();
            }
            List<RecenzijaZaposlenika> recenzijeSorted = korisnikoveRecenzije.OrderBy(k => k.DatumUnosa).ToList();
            return recenzijeSorted;
        }

        public static List<RecenzijaZaposlenika> DohvatiSveRecenzijeZaposlenikaKnjiznice(int? knjiznicaID)
        {
            List<RecenzijaZaposlenika> sveRecenzije = new List<RecenzijaZaposlenika>();

            using (var context = new Entities_db1())
            {
                var query = from r in context.ReviewEmployees
                            where r.LibraryUser1.LibraryID == knjiznicaID
                            select new RecenzijaZaposlenika
                            {
                                RecenzijaID = r.ReviewEmployeeID,
                                ImeZaposlenika = r.LibraryUser.Name,
                                PrezimeZaposlenika = r.LibraryUser.Surname,
                                KorisnikID = r.UserID,
                                KorisnickoIme = r.LibraryUser1.Username,
                                TekstRecenzije = r.ReviewText,
                                Ocjena = r.Stars,
                                ZaposlenikID = r.EmployeeID,
                                DatumUnosa = r.EntryDate
                            };
                sveRecenzije = query.ToList();
            }  
            List<RecenzijaZaposlenika> recenzijeSorted = sveRecenzije.OrderByDescending(k => k.DatumUnosa).ToList();
            return recenzijeSorted;
        }

        public static List<RecenzijaZaposlenika> DohvatiSveRecenzije()
        {
            List<RecenzijaZaposlenika> sveRecenzije = new List<RecenzijaZaposlenika>();

            using (var context = new Entities_db1())
            {
                var query = from r in context.ReviewEmployees
                            select new RecenzijaZaposlenika
                            {
                                RecenzijaID = r.ReviewEmployeeID,
                                ImeZaposlenika = r.LibraryUser.Name,
                                PrezimeZaposlenika = r.LibraryUser.Surname,
                                KorisnikID = r.UserID,
                                KorisnickoIme = r.LibraryUser1.Username,
                                TekstRecenzije = r.ReviewText,
                                Ocjena = r.Stars,
                                ZaposlenikID = r.EmployeeID,
                                DatumUnosa = r.EntryDate
                            };
                sveRecenzije = query.ToList();
            }
            List<RecenzijaZaposlenika> recenzijeSorted = sveRecenzije.OrderByDescending(k => k.DatumUnosa).ToList();
            return recenzijeSorted;
        }

        public static List<RecenzijaZaposlenika> DohvatiRecenzijeOdredenogZaposlenika(int? knjiznicaID, int zapolsenikID)
        {
            List<RecenzijaZaposlenika> recenzijeZaposlenika = new List<RecenzijaZaposlenika>();

            using (var context = new Entities_db1())
            {
                var query = from r in context.ReviewEmployees
                            where r.LibraryUser1.LibraryID == knjiznicaID && r.EmployeeID == zapolsenikID
                            select new RecenzijaZaposlenika
                            {
                                RecenzijaID = r.ReviewEmployeeID,
                                ImeZaposlenika = r.LibraryUser.Name,
                                PrezimeZaposlenika = r.LibraryUser.Surname,
                                KorisnikID = r.UserID,
                                KorisnickoIme = r.LibraryUser1.Username,
                                TekstRecenzije = r.ReviewText,
                                Ocjena = r.Stars,
                                ZaposlenikID = r.EmployeeID,
                                DatumUnosa = r.EntryDate
                            };
                recenzijeZaposlenika = query.ToList();
            }
            List<RecenzijaZaposlenika> recenzijeSorted = recenzijeZaposlenika.OrderByDescending(k => k.DatumUnosa).ToList();
            return recenzijeSorted;
        }

        public static RecenzijaZaposlenika DohvatiSpecificnuRecenziju(int korisnikID, int zapolsenikID)
        {
            RecenzijaZaposlenika recenzijaZaposlenika;

            using (var context = new Entities_db1())
            {
                var query = from r in context.ReviewEmployees
                            where r.UserID == korisnikID && r.EmployeeID == zapolsenikID
                            select new RecenzijaZaposlenika
                            {
                                RecenzijaID = r.ReviewEmployeeID,
                                ImeZaposlenika = r.LibraryUser.Name,
                                PrezimeZaposlenika = r.LibraryUser.Surname,
                                KorisnikID = r.UserID,
                                KorisnickoIme = r.LibraryUser1.Username,
                                TekstRecenzije = r.ReviewText,
                                Ocjena = r.Stars,
                                ZaposlenikID = r.EmployeeID,
                                DatumUnosa = r.EntryDate
                            };
                recenzijaZaposlenika = query.SingleOrDefault();
            }
            return recenzijaZaposlenika;
        }
        
        public void NovaRecenzija(string komentar, int ocjena, Korisnik korisnik, Korisnik zaposlenik)
        {
            ValidirajRecenziju(komentar);
            using (var context = new Entities_db1())
            {

                ReviewEmployee recenzija = new ReviewEmployee();

                recenzija.UserID = korisnik.KorisnikID;
                recenzija.EmployeeID = zaposlenik.KorisnikID;
                recenzija.ReviewText = komentar;
                recenzija.Stars = ocjena;
                recenzija.EntryDate = DateTime.Now;
                context.ReviewEmployees.Add(recenzija);
                context.SaveChanges();
            }
        }

        public void AžurirajRecenziju(string komentar, int ocjena, int korisnikID, int zaposlenikID)
        {
            ValidirajRecenziju(komentar);
            using (var context = new Entities_db1())
            {
                var recenzija = context.ReviewEmployees.First(r => r.LibraryUser1.UserID == korisnikID && r.LibraryUser.UserID == zaposlenikID);
                recenzija.ReviewText = komentar;
                recenzija.Stars = ocjena;
                recenzija.EntryDate = DateTime.Now;
                context.SaveChanges();
            }
        }

        private void ValidirajRecenziju(string komentar)
        {
            if (komentar.Length > 199 || komentar.Length < 1)
            {
                throw new RecenzijaException("Komentar mora imati između 200 i nula znakova!"); 
            }
        }

        public void ObrisiRecenziju()
        {
            using (var context = new Entities_db1())
            {
                var query = (from r in context.ReviewEmployees
                             where r.UserID == KorisnikID
                             select r).FirstOrDefault();
                context.ReviewEmployees.Remove(query);
                context.SaveChanges();

            }
        }

        public void ObrisiRecenziju2()
        {
            using (var context = new Entities_db1())
            {
                var query = (from r in context.ReviewEmployees
                             where r.EmployeeID == KorisnikID
                             select r).FirstOrDefault();
                context.ReviewEmployees.Remove(query);
                context.SaveChanges();

            }
        }
    }
}

