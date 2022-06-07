using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitBooks_Project.Klase
{
    public class Rezervacija
    {
        public int RezervacijaID { get; set; }
        public int KorisnikID { get; set; }
        public int IzdanjeID { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public DateTime DatumDostupnosti { get; set; }

        public static List<Rezervacija> DohvatiRezervacijeKorisnika(int korisnikID)
        {
            List<Rezervacija> rezervacijeKorisnika = new List<Rezervacija>();

            using (var context = new Entities_db1())
            {
                var query = from r in context.Reservations
                            where r.UserID == korisnikID
                            select new Rezervacija
                            {
                                RezervacijaID = r.ReservationID,
                                KorisnikID = r.UserID,
                                IzdanjeID = r.PublishingID,
                                DatumRezervacije = r.DateReserved,
                                DatumDostupnosti = r.DateAvailable
                            };
                rezervacijeKorisnika = query.ToList();
            }

            return rezervacijeKorisnika;
        }

        public List<Rezervacija> DohvatiRezervacijeIzdanja(int izdanjeID)
        {
            List<Rezervacija> rezervacijeIzdanja = new List<Rezervacija>();

            using (var context = new Entities_db1())
            {
                var query = from r in context.Reservations
                            where r.PublishingID == izdanjeID
                            select new Rezervacija
                            {
                                RezervacijaID = r.ReservationID,
                                KorisnikID = r.UserID,
                                IzdanjeID = r.PublishingID,
                                DatumRezervacije = r.DateReserved,
                                DatumDostupnosti = r.DateAvailable
                            };
                rezervacijeIzdanja = query.ToList();
            }

            return rezervacijeIzdanja;
        }

        public static void ObrisiRezervaciju(Rezervacija rezervacija)
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

        public void ObrisiRezervaciju()
        {
            using (var context = new Entities_db1())
            {
                var query = (from r in context.Reservations
                             where r.UserID == KorisnikID
                             select r).FirstOrDefault();
                context.Reservations.Remove(query);
                context.SaveChanges();

            }
        }
    }
}
