using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Basicas
{
    public class RitmoEvento
    {
        private Ritmo cdRitmo;
        private Evento cdEvento;

        public RitmoEvento()
        {
            cdRitmo = new Ritmo();
            cdEvento = new Evento();
        }

        public Ritmo CdRitmo
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

        public Evento CdEvento
        {
            get
            {
                return cdEvento;
            }

            set
            {
                cdEvento = value;
            }
        }
    }
}
