using bitBooks_Project.Dorian_Iznimke;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitBooks_Project.Klase
{
    public class Knjižnica
    {
        public int KnjižnicaID { get; set; }
        public int? Admin { get; set; }
        public string Ime { get; set; }

        public static List<Knjižnica> DohvatiSveKnjiznice() 
        {
            List<Knjižnica> sveKnjiznice = new List<Knjižnica>();

            using (var context = new Entities_db1()) 
            {
                var query = from l in context.Libraries
                            select new Knjižnica 
                            {
                                KnjižnicaID = l.LibraryID,
                                Admin = l.Administrator,
                                Ime = l.Name
                            };
                sveKnjiznice = query.ToList();
            }

            return sveKnjiznice;
        }

        public static Knjižnica DohvatiKnjiznicuTrenutnogKorisnika()
        {
            Knjižnica knjižnica = new Knjižnica();

            using (var context = new Entities_db1())
            {
                var query = from l in context.Libraries
                            where l.LibraryID == Sesija.Korisnik.KnjiznicaID
                            select new Knjižnica
                            {
                                KnjižnicaID = l.LibraryID,
                                Admin = l.Administrator,
                                Ime = l.Name
                            };
                knjižnica = query.SingleOrDefault();
            }

            return knjižnica;
        }

        public override string ToString()
        {
            return Ime;
        }

        public static Library NovaKnjiznica(string ime, int adminID)
        {
            ValidirajIme(ime);
            using (var context = new Entities_db1())
            {

                Library knjiznica = new Library();

                knjiznica.Name = ime;
                knjiznica.Administrator = adminID;
                context.Libraries.Add(knjiznica);
                context.SaveChanges();
                return knjiznica;
            }
        }

        public void AžurirajKnjiznicu(string ime)
        {
            ValidirajIme(ime);
            using (var context = new Entities_db1())
            {
                var knjiznica = context.Libraries.First(l => l.LibraryID == KnjižnicaID);
                knjiznica.Name = ime;
                context.SaveChanges();
            }
        }

        private static void ValidirajIme(string ime)
        {
            if (ime.Length > 50 || ime.Length < 1 )
            {
                throw new KnjiznicaException("Ime knjižnice mora imati maksimlano 50 znakova i ne smije ostati prazno!");
            }
        }
        public  void ObrisiKnjiznicu()
        {
            using (var context = new Entities_db1())
            {
                var query = (from l in context.Libraries
                             where l.LibraryID == KnjižnicaID
                             select l).FirstOrDefault();
                context.Libraries.Remove(query);
                context.SaveChanges();

            }
        }

    }
}
