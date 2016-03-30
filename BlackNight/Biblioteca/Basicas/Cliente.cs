using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Basicas
{
    public class Cliente
    {
        private int cdCliente;
        private string nmCliente;
        private string cpfCliente;
        private string emailCliente;
        private DateTime dtNascCliente;
        private string sxCliente;
        private string numCliente;


        public int CdCliente
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

        public string EmailCliente
        {
            get
            {
                return emailCliente;
            }

            set
            {
                emailCliente = value;
            }
        }

        public string NmCliente
        {
            get
            {
                return nmCliente;
            }

            set
            {
                nmCliente = value;
            }
        }

        public DateTime DtNascCliente
        {
            get
            {
                return dtNascCliente;
            }

            set
            {
                dtNascCliente = value;
            }
        }

        public string SxCliente
        {
            get
            {
                return sxCliente;
            }

            set
            {
                sxCliente = value;
            }
        }

        public string NumCliente
        {
            get
            {
                return numCliente;
            }

            set
            {
                numCliente = value;
            }
        }

        public string CpfCliente
        {
            get
            {
                return cpfCliente;
            }

            set
            {
                cpfCliente = value;
            }
        }
    }
}
