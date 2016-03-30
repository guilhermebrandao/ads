using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Basicas
{
    public class Ritmo
    {
        private int cdRitmo;
        private string nmRitmo;

        public int CdRitmo
        {
            get
            {
                return cdRitmo;
            }

            set
            {
                cdRitmo = value;
            }
        }

        public string NmRitmo
        {
            get
            {
                return nmRitmo;
            }

            set
            {
                nmRitmo = value;
            }
        }
    }
}
