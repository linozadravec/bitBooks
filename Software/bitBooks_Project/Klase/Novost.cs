using Aspose.Pdf;
using bitBooks_Project.Dorian_Iznimke;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace bitBooks_Project.Klase
{
    public class Novost
    {
        public int NovostId { get; set; }
        public string Ime { get; set; }
        public string Opis { get; set; }
        public int KnjiznicaID { get; set; }

        public static List<Novost> DohvatiNovostiKnjiznice(int? knjiznicaID)
        {
            List<Novost> novostiKnjiznice = new List<Novost>();

            using (var context = new Entities_db1())
            {
                var query = from n in context.News
                            where n.library_id == knjiznicaID
                            select new Novost
                            {
                                NovostId = n.news_id,
                                Ime = n.name,
                                Opis = n.description,
                                KnjiznicaID = n.library_id
                            };
                novostiKnjiznice = query.ToList();
            }
            ProvjeriListu(novostiKnjiznice);
            List<Novost> novostiSorted = novostiKnjiznice.OrderByDescending(k => k.NovostId).ToList();
            return novostiSorted;
        }

        public static List<Novost> DohvatiNovostiSve()
        {
            List<Novost> novostiKnjiznice = new List<Novost>();

            using (var context = new Entities_db1())
            {
                var query = from n in context.News
                            select new Novost
                            {
                                NovostId = n.news_id,
                                Ime = n.name,
                                Opis = n.description,
                                KnjiznicaID = n.library_id
                            };
                novostiKnjiznice = query.ToList();
            }
            ProvjeriListu(novostiKnjiznice);
            List<Novost> novostiSorted = novostiKnjiznice.OrderByDescending(k => k.NovostId).ToList();
            return novostiSorted;
        }

        public static void NovaNovost(string naziv, string opis,int knjiznicaID)
        {
            ValidirajUnose(naziv, opis);
            using (var context = new Entities_db1())
            {

                News novost = new News();

                novost.name = naziv;
                novost.description = opis;
                novost.library_id = knjiznicaID;
                context.News.Add(novost);
                context.SaveChanges();
            }
        }

        public void AžurirajNovost(string naziv, string opis, int novostID)
        {
            ValidirajUnose(naziv,opis);
            using (var context = new Entities_db1())
            {
                var novost = context.News.First(n => n.news_id == novostID);
                novost.name = naziv;
                novost.description = opis;
                context.SaveChanges();    
            }
        }

        private static void ValidirajUnose(string naziv, string opis)
        {
            if (opis.Length > 199 || opis.Length < 1 || naziv.Length > 19 || naziv.Length < 1)
            {
                throw new UnosNovostiException("Broj znakova naziva mora biti između 0 i 50, a opis između 0 i 200");
            }
        }

        private static void ProvjeriListu(List<Novost> novosti)
        {
            if (novosti.Count == 0)
            {
                throw new UnosNovostiException("Još ne postoje nikakve novosti!");
            }
        }
    }
}
