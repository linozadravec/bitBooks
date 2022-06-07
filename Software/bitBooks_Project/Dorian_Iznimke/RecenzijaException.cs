using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitBooks_Project.Dorian_Iznimke
{
    class RecenzijaException : LibraryException
    {
        public RecenzijaException(string poruka)
            : base(poruka)
        {
        }
    }
}
