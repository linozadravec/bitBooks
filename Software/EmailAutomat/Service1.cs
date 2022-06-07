using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Mail;
using System.Net;

namespace EmailAutomat
{
    public partial class Service1 : ServiceBase
    {
        System.Diagnostics.EventLog bitBooksDnevnik = new System.Diagnostics.EventLog();

        MailAddress primatelj = new MailAddress("svencerovec00@gmail.com");
        MailAddress posiljatelj = new MailAddress("arhitektura.webdip@gmail.com", "bitBooks Knjižnica", System.Text.Encoding.UTF8);

        public Service1()
        {
            InitializeComponent();
             if (!System.Diagnostics.EventLog.SourceExists("bitBooksMail"))
            {
                System.Diagnostics.EventLog.CreateEventSource("bitBooksMail", "EmailAutomat");
            }

            bitBooksDnevnik.Source = "bitBooksMail";
            bitBooksDnevnik.Log = "EmailAutomat";

        }

        private void Vrijeme(DateTime datum)
        {
            bitBooksDnevnik.WriteEntry("Datum");

            var trenutno_vrijeme = DateTime.Now;
            TimeSpan vrijeme_proteklo;

            if (datum > trenutno_vrijeme)
            {
                vrijeme_proteklo = datum - trenutno_vrijeme;
            }

            else
            {
                datum = DohvatiSljedeciDatum(datum, 0, 6, 0);
                vrijeme_proteklo = datum - trenutno_vrijeme;
            }

            if (vrijeme_proteklo.Days < 0 || vrijeme_proteklo.Hours < 0 || vrijeme_proteklo.Minutes < 0)
            {
                vrijeme_proteklo = datum - trenutno_vrijeme;
            }

            Task.Delay(vrijeme_proteklo).ContinueWith((x) =>
            {
                KreirajMail(datum);

                Vrijeme(DohvatiSljedeciDatum(datum, 0, 6, 0));

            }).Wait();
        }

        private DateTime DohvatiSljedeciDatum(DateTime datum, int dani, int sati = 0, int minute = 0)
        {
            DateTime sljedeciDatum = datum.AddDays(dani).AddHours(sati).AddMinutes(minute);
            bitBooksDnevnik.WriteEntry("Sljedeci email ce se poslati na datum: "+ sljedeciDatum.ToShortDateString() + "u " + sljedeciDatum.ToShortTimeString());
            return sljedeciDatum;
        }

        private void KreirajMail(DateTime datum)
        {
            bitBooksDnevnik.WriteEntry("U metodi salji mail: Procesiranje");

            bitBooksDnevnik.WriteEntry("Poruka se šalje na: " + primatelj);

            string sadrzaj = "Test Windows service - Poslano dana: " + datum.ToShortDateString() + " u " + datum.ToShortTimeString();

            string naslov = "Testiranje Windows Servisa";

            SaljiMail(sadrzaj, primatelj.ToString(), naslov);
            System.Threading.Thread.Sleep(2000);
        }

        private void SaljiMail(string sadrzaj, string primatelj, string naslov)
        {
            bitBooksDnevnik.WriteEntry("U metodi SaljiMail!");
            System.Threading.Tasks.Task t = System.Threading.Tasks.Task.Run(async () =>
           {
               SmtpClient client = new SmtpClient
               {
                   Host = "smtp.gmail.com",
                   Port = 25,
                   DeliveryMethod = SmtpDeliveryMethod.Network,
                   Credentials = new NetworkCredential("arhitektura.webdip@gmail.com", "qwers1c88")
               };

               

               MailMessage message = new MailMessage(primatelj, posiljatelj.ToString());

               message.IsBodyHtml = true;
               message.Body = "test";
               message.Subject = "test naslov";
               message.BodyEncoding = System.Text.Encoding.UTF8;
               message.SubjectEncoding = System.Text.Encoding.UTF8;

               await client.SendMailAsync(message);
               bitBooksDnevnik.WriteEntry("Mail uspjesno poslan!");
           });

            try
            {
                t.Wait();
            }
            catch (Exception ex)
            {

                bitBooksDnevnik.WriteEntry("Došlo je do pogreške: " + ex.Message);
            }
            finally
            {
                if (t != null)
                {
                    t.Dispose();
                }
            }

        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }
    }
}
