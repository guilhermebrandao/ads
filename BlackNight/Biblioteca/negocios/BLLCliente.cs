using Biblioteca.Basicas;
using Biblioteca.dados;
using Biblioteca.erros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.negocios
{
    public class BLLCliente
    {
        public readonly IDAO<Cliente> dao;

        public BLLCliente()
        {
            dao = new DAOCliente();
        }

        public void Inserir(Cliente c)
        {
            try
            {
                dao.Save(c);
            }
            catch (DAOException)
            {

                throw;
            }
        }
        public void Alterar(Cliente c)
        {
            try
            {
                dao.Save(c);
            }
            catch (DAOException)
            {
                throw;
            }
        }

        public void Excluir(Cliente c)
        {
            try
            {
                dao.Delete(c);
            }
            catch (DAOException)
            {
                throw;
            }
        }
        public List<Cliente> Listar()
        {
            return dao.getList();
        }

        public Cliente PesquisarCliente(int id)
        {
            return dao.getObject(id);
        }
    }
}
