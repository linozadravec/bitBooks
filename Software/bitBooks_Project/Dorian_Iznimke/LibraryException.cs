using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitBooks_Project.Dorian_Iznimke
{
    class LibraryException : ApplicationException
    {
        public string Poruka { get; set; }
        public LibraryException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
