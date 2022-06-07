using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitBooks_Project.Klase
{
    public class Grad
    {
        public int PostanskiBroj { get; set; }
        public string Ime { get; set; }

        public List<Grad> DohvatiSveGradove() 
        {
            List<Grad> sviGradovi = new List<Grad>();

            using (var context = new Entities_db1()) 
            {
                var query = from c in context.Cities
                            select new Grad
                            {
                                PostanskiBroj = c.PostalCode,
                                Ime = c.Name
                            };
                sviGradovi = query.ToList();
            }

                return sviGradovi;
        }

        public Grad DohvatiOdredeniGrad(int postanskiBroj)
        {
            Grad dohvaceniGrad;

            using (var context = new Entities_db1())
            {
                var query = from c in context.Cities
                            where c.PostalCode == postanskiBroj
                            select new Grad
                            {
                                PostanskiBroj = c.PostalCode,
                                Ime = c.Name
                            };
                dohvaceniGrad = query.Single();
            }

            return dohvaceniGrad;
        }
    }
}
