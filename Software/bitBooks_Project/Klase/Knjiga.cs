using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitBooks_Project.Klase
{
    public class Knjiga
    {
        public string ISBN { get; set; }
        public string Ime { get; set; }
        public int ŽanrID { get; set; }
        public int GodinaPisanja { get; set; }

        public List<Knjiga> DohvatiKnjigeZanra(int zanrID) 
        {
            List<Knjiga> knjigeZanra = new List<Knjiga>();

            using (var context = new Entities_db1()) 
            {
                var query = from b in context.Books
                            where b.GenreID == zanrID
                            select new Knjiga
                            {
                                ISBN = b.ISBN,
                                Ime = b.Name,
                                ŽanrID = b.GenreID,
                                GodinaPisanja = b.YearWritten
                            };
                knjigeZanra = query.ToList();
            }

            return knjigeZanra;
        }

        public List<Knjiga> DohvatiKnjigeImena(string ime)
        {
            List<Knjiga> knjigeImena = new List<Knjiga>();

            using (var context = new Entities_db1())
            {
                var query = from b in context.Books
                            where b.Name == ime
                            select new Knjiga
                            {
                                ISBN = b.ISBN,
                                Ime = b.Name,
                                ŽanrID = b.GenreID,
                                GodinaPisanja = b.YearWritten
                            };
                knjigeImena = query.ToList();
            }

            return knjigeImena;
        }
        public static List<Knjiga> DohvatiKnjige()
        {
            List<Knjiga> knjigeImena = new List<Knjiga>();

            using (var context = new Entities_db1())
            {
                var query = from b in context.Books
                            select new Knjiga
                            {
                                ISBN = b.ISBN,
                                Ime = b.Name,
                                ŽanrID = b.GenreID,
                                GodinaPisanja = b.YearWritten
                            };
                knjigeImena = query.ToList();
            }

            return knjigeImena;
        }

        public static List<Knjiga> DohvatiNedostupneKnjige()
        {
            List<Knjiga> knjigeImena = new List<Knjiga>();

            using (var context = new Entities_db1())
            {
                var query = from b in context.Books
                            join i in context.Publishings
                            on b.ISBN equals i.ISBN
                            where i.NumLoaned > 0
                            select new Knjiga
                            {
                                ISBN = b.ISBN,
                                Ime = b.Name,
                                ŽanrID = b.GenreID,
                                GodinaPisanja = b.YearWritten
                            };
                knjigeImena = query.Distinct().ToList();
            }

            return knjigeImena;
        }

        public static List<Knjiga> DohvatiDostupneKnjige()
        {
            List<Knjiga> knjigeImena = new List<Knjiga>();

            using (var context = new Entities_db1())
            {
                var query = from b in context.Books
                            join i in context.Publishings
                            on b.ISBN equals i.ISBN
                            where i.NumLoaned == 0
                            select new Knjiga
                            {
                                ISBN = b.ISBN,
                                Ime = b.Name,
                                ŽanrID = b.GenreID,
                                GodinaPisanja = b.YearWritten
                            };
                knjigeImena = query.Distinct().ToList();
            }

            return knjigeImena;
        }
    }
}
