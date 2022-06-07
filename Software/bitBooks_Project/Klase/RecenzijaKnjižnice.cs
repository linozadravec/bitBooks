using bitBooks_Project.Dorian_Iznimke;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitBooks_Project.Klase
{
    public class RecenzijaKnjižnice : Recenzija
    {
        public int? KnjižnicaID { get; set; }
        public string ImeKnjižnice { get; set; }
        public static int[] listaOcjena = new int[5] { 1, 2, 3, 4, 5 };
        public RecenzijaKnjižnice()
            :base ()
        {
            
        }

        public static RecenzijaKnjižnice DohvatiKorisnikoveRecenzijeKnjiznice(int korisnikID) 
        {
            RecenzijaKnjižnice korisnikovaRecenzija;

            using (var context = new Entities_db1())
            {
                var query = from r in context.ReviewLibraries
                            where r.UserID == korisnikID
                            select new RecenzijaKnjižnice
                            {
                                RecenzijaID = r.ReviewLibraryID,
                                KorisnikID = r.UserID,
                                TekstRecenzije = r.ReviewText,
                                Ocjena = r.Stars,
                                KnjižnicaID = r.LibraryUser.LibraryID,
                                ImeKnjižnice = r.LibraryUser.Library.Name,
                                KorisnickoIme = r.LibraryUser.Username,
                                DatumUnosa = r.EntryDate
                            };

                if (query != null)
                {
                    korisnikovaRecenzija = query.SingleOrDefault();
                }
                else
                {
                    korisnikovaRecenzija = null;
                }

                return korisnikovaRecenzija;
            }
        }

        public static List<RecenzijaKnjižnice> DohvatiSveRecenzijeKnjiznice(int? knjiznicaID)
        {
            List<RecenzijaKnjižnice> sveRecenzije = new List<RecenzijaKnjižnice>();

            using (var context = new Entities_db1())
            {
                var query = from r in context.ReviewLibraries
                            where r.LibraryUser.LibraryID == knjiznicaID
                            select new RecenzijaKnjižnice
                            {
                                RecenzijaID = r.ReviewLibraryID,
                                KorisnikID = r.UserID,
                                TekstRecenzije = r.ReviewText,
                                Ocjena = r.Stars,
                                KnjižnicaID = r.LibraryUser.LibraryID,
                                ImeKnjižnice = r.LibraryUser.Library.Name,
                                KorisnickoIme = r.LibraryUser.Username,
                                DatumUnosa = r.EntryDate
                            };
                sveRecenzije = query.ToList();
            }
            List<RecenzijaKnjižnice> recenzijeSorted = sveRecenzije.OrderByDescending(k => k.DatumUnosa).ToList();
            return recenzijeSorted;
        }

        public static List<RecenzijaKnjižnice> DohvatiSveRecenzije()
        {
            List<RecenzijaKnjižnice> sveRecenzije = new List<RecenzijaKnjižnice>();

            using (var context = new Entities_db1())
            {
                var query = from r in context.ReviewLibraries
                            select new RecenzijaKnjižnice
                            {
                                RecenzijaID = r.ReviewLibraryID,
                                KorisnikID = r.UserID,
                                TekstRecenzije = r.ReviewText,
                                Ocjena = r.Stars,
                                KnjižnicaID = r.LibraryUser.LibraryID,
                                ImeKnjižnice = r.LibraryUser.Library.Name,
                                KorisnickoIme = r.LibraryUser.Username,
                                DatumUnosa = r.EntryDate
                            };
                sveRecenzije = query.ToList();
            }
            List<RecenzijaKnjižnice> recenzijeSorted = sveRecenzije.OrderByDescending(k => k.DatumUnosa).ToList();
            return recenzijeSorted;
        }

        public void NovaRecenzija(string komentar, int ocjena, Korisnik korisnik) 
        {
            ValidirajRecenziju(komentar);   
            using (var context = new Entities_db1())
                {

                    ReviewLibrary recenzija = new ReviewLibrary();

                    recenzija.UserID = korisnik.KorisnikID;
                    recenzija.ReviewText = komentar;
                    recenzija.Stars = ocjena;
                    recenzija.EntryDate = DateTime.Now;
                    context.ReviewLibraries.Add(recenzija);
                    context.SaveChanges();
                }
        }

        public void AžurirajRecenziju(string komentar, int ocjena, int korisnikID)
        {
            ValidirajRecenziju(komentar);
            using (var context = new Entities_db1())
            {
                var recenzija = context.ReviewLibraries.First(r => r.LibraryUser.UserID == korisnikID);
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
                var query = (from r in context.ReviewLibraries
                             where r.UserID == KorisnikID
                             select r).FirstOrDefault();
                context.ReviewLibraries.Remove(query);
                context.SaveChanges();

            }
        }
    }
}
