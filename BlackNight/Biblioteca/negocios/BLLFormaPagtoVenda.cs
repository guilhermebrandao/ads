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
    public class BLLFormaPagtoVenda
    {
    public readonly IDAO<FormaPagtoVenda> dao;

        public BLLFormaPagtoVenda()
        {
            dao = new DAOFormaPagtoVenda();
        }

        public void Inserir(FormaPagtoVenda fpv)
        {
            try
            {
                dao.Save(fpv);
            }
            catch (DAOException)
            {

                throw;
            }
        }
        public void Alterar(FormaPagtoVenda fpv)
        {
            try
            {
                dao.Save(fpv);
            }
            catch (DAOException)
            {
                throw;
            }
        }
        public void Excluir(FormaPagtoVenda fpv)
        {
            try
            {
                dao.Delete(fpv);
            }
            catch (DAOException)
            {
                throw;
            }
        }
        public List<FormaPagtoVenda> Lista()
        {
            return dao.getList();
        }
        public FormaPagtoVenda PesquisarFormaPagtoVenda(int id)
        {
            try
            {
                return dao.getObject(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
        
    }
}


