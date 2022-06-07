using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitBooks_Project.Klase
{
    public class Posudba
    {
        public int PosudbaID { get; set; }
        public int KorisnikID { get; set; }
        public int IzdanjeID { get; set; }
        public DateTime DatumPovratka { get; set; }
        public string StatusPosudbe { get; set; }


        
        public static List<Posudba> DohvatiPosudbeKorisnika(int korisnikID) 
        {
            List<Posudba> posudbeKorisnika = new List<Posudba>();

            using (var context = new Entities_db1()) 
            {
                var query = from l in context.Loans
                            where l.UserID == korisnikID
                            select new Posudba
                            {
                                PosudbaID = l.LoanID,
                                KorisnikID = l.UserID,
                                IzdanjeID = l.PublishingID,
                                DatumPovratka = l.DueDate,
                                StatusPosudbe = l.LoanStatus
                            };
                posudbeKorisnika = query.ToList();
            }

            return posudbeKorisnika;
        }

        public List<Posudba> DohvatiPosudbeIzdanja(int izdanjeID)
        {
            List<Posudba> posudbeIzdanja = new List<Posudba>();

            using (var context = new Entities_db1())
            {
                var query = from l in context.Loans
                            where l.PublishingID == izdanjeID
                            select new Posudba
                            {
                                PosudbaID = l.LoanID,
                                KorisnikID = l.UserID,
                                IzdanjeID = l.PublishingID,
                                DatumPovratka = l.DueDate,
                                StatusPosudbe = l.LoanStatus
                            };
                posudbeIzdanja = query.ToList();
            }

            return posudbeIzdanja;
        }

        public void PromijeniStatus(int posudbaID) 
        {

            if (StatusPosudbe == enumStatusPosudbe.Posudena.ToString())
            {
                StatusPosudbe = enumStatusPosudbe.Vracena.ToString();
            }

            else 
            {
                StatusPosudbe = enumStatusPosudbe.Posudena.ToString();
            }

            if (StatusPosudbe == enumStatusPosudbe.Posudena.ToString() && DatumPovratka < DateTime.Now) 
            {
                StatusPosudbe = enumStatusPosudbe.Zakasnjela.ToString();
            }
        }
        public void ObrisiPosudbu()
        {
            using (var context = new Entities_db1())
            {
                var query = (from l in context.Loans
                             where l.UserID == KorisnikID
                             select l).FirstOrDefault();
                context.Loans.Remove(query);
                context.SaveChanges();

            }
        }
    }
}
