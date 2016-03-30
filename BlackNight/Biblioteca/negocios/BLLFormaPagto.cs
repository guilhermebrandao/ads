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
    public class BLLFormaPagto
    {
        public readonly IDAO<FormaPagto> dao;

        public BLLFormaPagto()
        {
            dao = new DAOFormaPagto();
        }

        public void Inserir(FormaPagto fp)
        {
            try
            {
                dao.Save(fp);
            }
            catch (DAOException)
            {

                throw;
            }
        }
        public void Alterar(FormaPagto fp)
        {
            try
            {
                dao.Save(fp);
            }
            catch (DAOException)
            {
                throw;
            }
        }

        public void Excluir(FormaPagto fp)
        {
            try
            {
                dao.Delete(fp);
            }
            catch (DAOException)
            {
                throw;
            }
        }
        public List<FormaPagto> Lista()
        {
            return dao.getList();
        }
        public FormaPagto PesquisarFormaPagto(string nome)
        {
            return dao.getId(nome);
        }
        public FormaPagto PesquisarFormaPagto(int id)
        {
            return dao.getObject(id);
        }
    }
}

