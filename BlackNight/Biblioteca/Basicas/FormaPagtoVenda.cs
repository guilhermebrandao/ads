using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Basicas
{
    public class FormaPagtoVenda
    {
        private double vlPago;
        private Evento cdEvento;
        private FormaPagto cdFormaPagto;

        public FormaPagtoVenda()
        {
            cdEvento = new Evento();
            cdFormaPagto = new FormaPagto();
        }
        public double VlPago
        {
            get
            {
                return vlPago;
            }

            set
            {
                vlPago = value;
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

        public FormaPagto CdFormaPagto
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
    }
}
