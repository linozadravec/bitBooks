using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace PodaciOKnjiziDll
{
    public class PodaciOKnjizi
    {      

        public static string Get(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        public string DohvatiOpisKnjige(string nazivKnjige)
        {
            string opis = "";
            string url = $"https://www.googleapis.com/books/v1/volumes?q={nazivKnjige}&key=AIzaSyARiLUOQqk1_wa4wAD7SMgz5v-meEhTlBc";
            string b = Get(url);
            JsonKnjiga.GoogleBooksApiResponse knjiga = JsonConvert.DeserializeObject<JsonKnjiga.GoogleBooksApiResponse>(b);
            foreach (var item in knjiga.items)
            {
                opis = item.volumeInfo.description;
                break;
            }
            return opis;
        }
        public string DohvatiIzdavačaKnjige(string nazivKnjige)
        {
            string izdavac = "";
            string url = $"https://www.googleapis.com/books/v1/volumes?q={nazivKnjige}&key=AIzaSyARiLUOQqk1_wa4wAD7SMgz5v-meEhTlBc";
            string b = Get(url);
            JsonKnjiga.GoogleBooksApiResponse knjiga = JsonConvert.DeserializeObject<JsonKnjiga.GoogleBooksApiResponse>(b);
            foreach (var item in knjiga.items)
            {
                izdavac = item.volumeInfo.publisher;
                break;
            }
            return izdavac;
        }

        public string DohvatiDatumIzdavanja(string nazivKnjige)
        {
            string datumIzdavanja = "";
            string url = $"https://www.googleapis.com/books/v1/volumes?q={nazivKnjige}&key=AIzaSyARiLUOQqk1_wa4wAD7SMgz5v-meEhTlBc";
            string b = Get(url);
            JsonKnjiga.GoogleBooksApiResponse knjiga = JsonConvert.DeserializeObject<JsonKnjiga.GoogleBooksApiResponse>(b);
            foreach (var item in knjiga.items)
            {
                datumIzdavanja = item.volumeInfo.publishedDate;
                break;
            }
            return datumIzdavanja;
        }
        public int DohvatiBrojStranica(string nazivKnjige)
        {
            int brojstranica = 0;
            string url = $"https://www.googleapis.com/books/v1/volumes?q={nazivKnjige}&key=AIzaSyARiLUOQqk1_wa4wAD7SMgz5v-meEhTlBc";
            string b = Get(url);
            JsonKnjiga.GoogleBooksApiResponse knjiga = JsonConvert.DeserializeObject<JsonKnjiga.GoogleBooksApiResponse>(b);
            foreach (var item in knjiga.items)
            {
                brojstranica = item.volumeInfo.pageCount;
                break;
            }
            return brojstranica;
        }

        public double DohvatiRecenzije(string nazivKnjige)
        {
            double ocjena = 0;
            string url = $"https://www.googleapis.com/books/v1/volumes?q={nazivKnjige}&key=AIzaSyARiLUOQqk1_wa4wAD7SMgz5v-meEhTlBc";
            string b = Get(url);
            JsonKnjiga.GoogleBooksApiResponse knjiga = JsonConvert.DeserializeObject<JsonKnjiga.GoogleBooksApiResponse>(b);
            foreach (var item in knjiga.items)
            {
                ocjena = item.volumeInfo.averageRating;
                break;
            }
            return ocjena;
        }
         
        }

    }

