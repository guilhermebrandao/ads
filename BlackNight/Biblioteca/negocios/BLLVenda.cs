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

    public class BLLVenda
    {
        public readonly IDAO<Venda> dao;

        public BLLVenda()
        {
            dao = new DAOVenda();
        }

        public void Inserir(Venda v)
        {
            try
            {
                dao.Save(v);
            }
            catch (DAOException)
            {
                throw;
            }
        }

        public void Alterar(Venda v)
        {
            try
            {
                dao.Save(v);
            }
            catch (DAOException)
            {
                throw;
            }
        }

        public void Excluir(Venda v)
        {
            try
            {
                dao.Delete(v);
            }
            catch (DAOException)
            {
                throw;
            }
        }

        public List<Venda> Lista()
        {
            return dao.getList();
        }

        public Venda PesquisaVenda(int id)
        {
            return dao.getObject(id);
        }

        public Venda PesquisaVenda(int idCliente, int idEvento, DateTime dtEvento)
        {
            return dao.getId(idCliente, idEvento, dtEvento);
        }


    }
}
