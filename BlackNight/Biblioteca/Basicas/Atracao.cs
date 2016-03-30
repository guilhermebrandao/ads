using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Basicas
{
    public class Atracao
    {
        private int cdAtracao;
        private string numAtracao;
        private string nmAtracao;

        public int CdAtracao
        {
            get
            {
                return cdAtracao;
            }

            set
            {
                cdAtracao = value;
            }
        }

        public string NumAtracao
        {
            get
            {
                return numAtracao;
            }

            set
            {
                numAtracao = value;
            }
        }

        public string NmAtracao
        {
            get
            {
                return nmAtracao;
            }

            set
            {
                nmAtracao = value;
            }
        }
    }
}
