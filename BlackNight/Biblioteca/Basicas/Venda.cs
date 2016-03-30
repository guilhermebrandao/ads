using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Basicas
{
    public class Venda
    {
        private int cdVenda;
        private Cliente cdCliente;
        private Evento cdEvento;
        private DateTime dtVenda;

        public Venda()
        {
            cdCliente = new Cliente();
            cdEvento = new Evento();
        }

        #region Gets and Sets  
             
        public int CdVenda
        { 
            get
            {
                return cdVenda;
            }

            set
            {
                cdVenda = value;
            }
        }

        public Cliente CdCliente
        {
            get
            {
                return cdCliente;
            }

            set
            {
                cdCliente = value;
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

        public DateTime DtVenda
        {
            get
            {
                return dtVenda;
            }

            set
            {
                dtVenda = value;
            }
        }

        #endregion
        public Boolean isValido()
        {
            if (this.cdCliente == null)
                return false;
            if (this.cdEvento == null)
                return false;
            if ((this.cdVenda).ToString() == null)
                return false;
            if (this.dtVenda == null)
                return false;
            return true;
        }

    }
}
