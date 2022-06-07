using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitBooks_Project.Dorian_Iznimke
{
    class KorisnikException : ApplicationException
    {
        public string Poruka { get; set; }
        public KorisnikException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
