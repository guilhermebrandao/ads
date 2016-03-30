using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.util
{
    public interface IConexao
    {
        /// <summary>
        /// Abre conexão com o servidor.
        /// </summary>
        void AbrirConexao();

        /// <summary>
        /// Fecha conexão com o servidor.
        /// </summary>
        void FecharConexao();
    }
}
