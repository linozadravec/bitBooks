using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitBooks_Project.Klase
{
    public class Obavijest
    {
        public int KorisnikID { get; set; }
        public string Poruka { get; set; }
        public DateTime Datum { get; set; }

        
        public static List<Obavijest> DohvatiObavijestiKorisnika(int KorisnikID)
        {
            List<Obavijest> ob = new List<Obavijest>();

            using (var context = new Entities_db1())
            {
                var query = from n in context.Notifications
                            where n.UserID == KorisnikID
                            select new Obavijest
                            {
                                KorisnikID = n.UserID,
                                Datum = n.Datetime,
                                Poruka = n.Message
                            };

                ob = query.ToList();

            }
            return ob;
        }

        public static void GeneriranjeObavijestiPosudbe(int KorisnikID, string Imeknjige)
        {
            
            using (var context = new Entities_db1())
            {

                Notification obavijest = new Notification();

                obavijest.UserID = KorisnikID;
                obavijest.Datetime = DateTime.Now;
                obavijest.Message = "Uspješno ste posudili knjigu "+ Imeknjige +", rok vraćanja je "+ DateTime.Today.AddDays(30);

                context.Notifications.Add(obavijest);
                context.SaveChanges();
            }
        }
        public static void GeneriranjeObavijestiRezervacije(int KorisnikID, string Imeknjige)
        {

            using (var context = new Entities_db1())
            {

                Notification obavijest = new Notification();

                obavijest.UserID = KorisnikID;
                obavijest.Datetime = DateTime.Now;
                obavijest.Message = "Uspješno ste rezervirali knjigu " + Imeknjige + ", mogućom posudbom biti ćete obavješteni Emailom";

                context.Notifications.Add(obavijest);
                context.SaveChanges();
            }
        }
        public static void GeneriranjeObavijestiRokVraćanja(int KorisnikID, string Imeknjige)
        {

            using (var context = new Entities_db1())
            {

                Notification obavijest = new Notification();

                obavijest.UserID = KorisnikID;
                obavijest.Datetime = DateTime.Now;
                obavijest.Message = "Vaša posuđena knjiga" + Imeknjige + " ima rok vraćanja " + DateTime.Today.AddDays(7) + ", ovo je podsjetnik za vraćanje knjige u sljedećih 7 dana!";

                context.Notifications.Add(obavijest);
                context.SaveChanges();
            }
        }

        public static void GeneriranjeObavijestiRegistracije(int KorisnikID)
        {
            using (var context = new Entities_db1())
            {

                Notification obavijest = new Notification();

                obavijest.UserID = KorisnikID;
                obavijest.Datetime = DateTime.Now;
                obavijest.Message = "Dobrodošli u naš sustav!";

                context.Notifications.Add(obavijest);
                context.SaveChanges();
            }
        }

    }


}
