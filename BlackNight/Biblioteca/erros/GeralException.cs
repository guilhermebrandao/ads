using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.erros
{
    public class GeralException : Exception
    {
        public GeralException()
        {
        }
        public GeralException(string e)
            : base(e)
        {
            ;
        }
        public GeralException(string message, Exception inner)
            : base(message, inner)
        {
            ;
        }
    }
}
