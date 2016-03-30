using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Basicas
{
    public class Evento
    {
        private int cdEvento;
        private Atracao cdAtracao;
        private DateTime dtEvento;
        private int qtdIngMasc;
        private int qtdIngFem;
        private Decimal vlIngMasc;
        private Decimal vlIngFem;
        private string nmEvento;

        public Evento()
        {
            cdAtracao = new Atracao();
        }

        public int CdEvento
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

        public Atracao CdAtracao
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

        public DateTime DtEvento
        {
            get
            {
                return dtEvento;
            }

            set
            {
                dtEvento = value;
            }
        }

        public int QtdIngMasc
        {
            get
            {
                return qtdIngMasc;
            }

            set
            {
                qtdIngMasc = value;
            }
        }

        public int QtdIngFem
        {
            get
            {
                return qtdIngFem;
            }

            set
            {
                qtdIngFem = value;
            }
        }

        public decimal VlIngMasc
        {
            get
            {
                return vlIngMasc;
            }

            set
            {
                vlIngMasc = value;
            }
        }

        public decimal VlIngFem
        {
            get
            {
                return vlIngFem;
            }

            set
            {
                vlIngFem = value;
            }
        }

        public string NmEvento
        {
            get
            {
                return nmEvento;
            }

            set
            {
                nmEvento = value;
            }
        }
    }
}
