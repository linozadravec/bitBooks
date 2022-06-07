using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitBooks_Project.Dorian_Iznimke
{
    class KnjiznicaException : ApplicationException
    {
        public string Poruka { get; set; }
        public KnjiznicaException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
