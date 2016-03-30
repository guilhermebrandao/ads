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
    public class BLLRitmo
    {
        public readonly IDAO<Ritmo> dao;

        public BLLRitmo()
        {
            dao = new DAORitmo();
        }
        public void Inserir(Ritmo r)
        {
            try
            {
                dao.Save(r);
            }
            catch (DAOException)
            {

                throw;
            }
        }
        public void Alterar(Ritmo r)
        {
            try
            {
                dao.Save(r);
            }
            catch (DAOException)
            {
                throw;
            }
        }

        public void Excluir(Ritmo r)
        {
            try
            {
                dao.Delete(r);
            }
            catch (DAOException)
            {
                throw;
            }
        }
        public List<Ritmo> Listar()
        {
            return dao.getList();
        }
        public Ritmo PesquisarRitmo(int id)
        {
            return dao.getObject(id);
        }
    }
}
