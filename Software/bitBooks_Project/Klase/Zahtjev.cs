using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace bitBooks_Project.Klase
{
    public class Zahtjev
    {
        public int ZahtjevID { get; set; }
        public int KorisnikID { get; set; }
        public int? ZaposlenikID { get; set; }
        public string AdresaIPKorisnik { get; set; }

        public string AdresaIPZaposlenik { get; set; }


        public static Zahtjev NoviZahtjev()
        {
            Zahtjev zahtjev = new Zahtjev();
            

            using (var context = new Entities_db1())
            {
                Request request = new Request
                {
                    UserID = Sesija.Korisnik.KorisnikID,
                    AddressIPUser = GetIP()

                };

                context.Requests.Add(request);
                context.SaveChanges();

                zahtjev.KorisnikID = request.UserID;
                zahtjev.AdresaIPKorisnik = request.AddressIPUser;
                zahtjev.ZahtjevID = request.RequestID;

            }

            return zahtjev;
        }

        public static Zahtjev DohvatiNoviZahtjev()
        {
            Zahtjev zahtjev;

            using (var context = new Entities_db1())
            {
                var query = from l in context.Requests
                            where l.EmployeeID == null && l.LibraryUser1.LibraryID == Sesija.Korisnik.KnjiznicaID
                            select new Zahtjev
                            {
                                ZahtjevID = l.RequestID,
                                KorisnikID = l.UserID,
                                ZaposlenikID = l.EmployeeID,
                                AdresaIPKorisnik = l.AddressIPUser,
                                AdresaIPZaposlenik = l.AddressIPEmployee

                            };
                zahtjev = query.FirstOrDefault();
            }

            return zahtjev;
        }

        public static Zahtjev DohvatiZahtjevPoID(int zahtjevID)
        {
            Zahtjev zahtjev;

            using (var context = new Entities_db1())
            {
                var query = from l in context.Requests
                            where l.RequestID == zahtjevID
                            select new Zahtjev
                            {
                                ZahtjevID = l.RequestID,
                                KorisnikID = l.UserID,
                                ZaposlenikID = l.EmployeeID,
                                AdresaIPKorisnik = l.AddressIPUser,
                                AdresaIPZaposlenik = l.AddressIPEmployee

                            };
                zahtjev = query.FirstOrDefault();
            }

            return zahtjev;
        }

        public static Zahtjev AžurirajZahtjev(int zahtjevID, int zaposlenikID)
        {
            Zahtjev zahtjev = new Zahtjev();

            using (var context = new Entities_db1())
            {
                Request request = context.Requests.SingleOrDefault(x => x.RequestID == zahtjevID);
                request.EmployeeID = zaposlenikID;
                request.AddressIPEmployee = GetIP();
                context.SaveChanges();

                
                zahtjev.ZahtjevID = request.RequestID;
                zahtjev.KorisnikID = request.UserID;
                zahtjev.ZaposlenikID = request.EmployeeID;
                zahtjev.AdresaIPKorisnik = request.AddressIPUser;
                zahtjev.AdresaIPZaposlenik = request.AddressIPEmployee;

            }


            return zahtjev;
        }

        private static string GetIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();

            }


            return "127.0.0.1";
        }




    }


}
