using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.erros
{
    public class DAOException : Exception
    {
        public DAOException()
        {
        }
        public DAOException(string e)
            : base(e)
        {
            ;
        }
        public DAOException(string message, Exception inner)
            : base(message, inner)
        {
            ;
        }
    }
}

