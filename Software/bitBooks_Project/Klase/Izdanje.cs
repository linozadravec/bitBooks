using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitBooks_Project.Klase
{
    public class Izdanje
    {
        public int IzdanjeID { get; set; }
        public int? OdjelID { get; set; }
        public string ISBN { get; set; }
        public int IzdavacID { get; set; }
        public int BrojPosudenih { get; set; }
        public int BrojDostupnih { get; set; }
        public int? GodinaIzdavanja { get; set; }

        public static List<Izdanje> DohvatiIzdanjaKnjige(string isbn) 
        {
            List<Izdanje> izdanjaKnjige = new List<Izdanje>();

            using (var context = new Entities_db1())
            {
                var query = from p in context.Publishings
                            where p.ISBN == isbn
                            select new Izdanje 
                            {
                                IzdanjeID  = p.PublishingID,
                                OdjelID = p.DepartmentID,
                                ISBN = p.ISBN,
                                IzdavacID = p.PublisherID,
                                BrojPosudenih = p.NumLoaned,
                                BrojDostupnih = p.NumAvailable,
                                GodinaIzdavanja = p.ReleaseYear  
                            };
                izdanjaKnjige = query.ToList();
            }

            return izdanjaKnjige;
        }

        public void PromjenaStanja() 
        {
            //TODO nešto
        }

        private void PromijeniBrojPosudenih() 
        {
            // ako knjiga ide vun onda brojPosudenih++ ako nuter onda brojPosudenih--
        }
        private void PromijeniBrojDostupnih() 
        {
            // ako knjiga ide vun onda brojDostupnih-- ako nuter onda brojDostupnih++
        }

        public List<Izdanje> DohvatiIzdanjaIzdavaca(int izdavacID)
        {
            List<Izdanje> izdanjaIzdavaca = new List<Izdanje>();

            using (var context = new Entities_db1())
            {
                var query = from p in context.Publishings
                            where p.PublisherID == izdavacID
                            select new Izdanje
                            {
                                IzdanjeID = p.PublishingID,
                                OdjelID = p.DepartmentID,
                                ISBN = p.ISBN,
                                IzdavacID = p.PublisherID,
                                BrojPosudenih = p.NumLoaned,
                                BrojDostupnih = p.NumAvailable,
                                GodinaIzdavanja = p.ReleaseYear
                            };
                izdanjaIzdavaca = query.ToList();
            }

            return izdanjaIzdavaca;
        }

        public static List<Izdanje> DohvatiIzdanjaOdjela(int odjelID)
        {
            List<Izdanje> izdanjaOdjela = new List<Izdanje>();

            using (var context = new Entities_db1())
            {
                var query = from p in context.Publishings
                            where p.DepartmentID == odjelID
                            select new Izdanje
                            {
                                IzdanjeID = p.PublishingID,
                                OdjelID = p.DepartmentID,
                                ISBN = p.ISBN,
                                IzdavacID = p.PublisherID,
                                BrojPosudenih = p.NumLoaned,
                                BrojDostupnih = p.NumAvailable,
                                GodinaIzdavanja = p.ReleaseYear
                            };
                izdanjaOdjela = query.ToList();
            }

            return izdanjaOdjela;
        }

        public void ObrisiIzdanje()
        {
            using (var context = new Entities_db1())
            {
                var query = (from p in context.Publishings
                             where p.DepartmentID == OdjelID
                             select p).FirstOrDefault();
                context.Publishings.Remove(query);
                context.SaveChanges();

            }
        }
    }

    
}
