using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Basicas
{
    public class FormaPagto
    {
        private int cdFormaPagto;
        private string descFormaPagto;

        public int CdFormaPagto
        {
            get
            {
                return cdFormaPagto;
            }

            set
            {
                cdFormaPagto = value;
            }
        }

        public string DescFormaPagto
        {
            get
            {
                return descFormaPagto;
            }

            set
            {
                descFormaPagto = value;
            }
        }
    }
}
