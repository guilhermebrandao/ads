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
    public class BLLRitmoEvento
    {
        public readonly IDAO<RitmoEvento> dao;

        public BLLRitmoEvento()
        {
            dao = new DAORitmoEvento();
        }
        public void Inserir(RitmoEvento re)
        {
            try
            {
                dao.Save(re);
            }
            catch (DAOException)
            {

                throw;
            }
        }
        public void Alterar(RitmoEvento a)
        {
            try
            {
                dao.Save(a);
            }
            catch (DAOException)
            {
                throw;
            }
        }

        public void Excluir(RitmoEvento a)
        {
            try
            {
                dao.Delete(a);
            }
            catch (DAOException)
            {
                throw;
            }
        }
        public List<RitmoEvento> Lista()
        {
            return dao.getList();
        }
        public RitmoEvento PesquisarRitmoEvento(int id)
        {
            return dao.getObject(id);
        }
    }
}