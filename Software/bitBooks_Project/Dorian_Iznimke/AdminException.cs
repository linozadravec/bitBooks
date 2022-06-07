using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitBooks_Project.Dorian_Iznimke
{
    class AdminException : LibraryException
    {
        public AdminException(string poruka)
            : base(poruka)
        {
        }
    }
}
