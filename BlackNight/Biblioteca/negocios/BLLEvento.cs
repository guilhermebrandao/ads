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
    public class BLLEvento
    {
        public readonly IDAO<Evento> dao;

        public BLLEvento()
        {
            dao = new DAOEvento();
        }
        public void Inserir(Evento ev)
        {
            try
            {
                dao.Save(ev);
            }
            catch (DAOException)
            {

                throw;
            }
        }
        public void Alterar(Evento ev)
        {
            try
            {
                dao.Save(ev);
            }
            catch (DAOException)
            {
                throw;
            }
        }

        public void Excluir(Evento ev)
        {
            try
            {
                dao.Delete(ev);
            }
            catch (DAOException)
            {
                throw;
            }
        }
        public List<Evento> Lista()
        {
            return dao.getList();
        }
        public DateTime ProcurarData(string nome)
        {
            return dao.getDate(nome);
        }
        public Evento ProcurarPreco(int id, string tipoIngresso)
        {
            return dao.getPreco(id, tipoIngresso);
        }

        public Evento ProcurarEvento(int id)
        {
            return dao.getObject(id);
        }
    }
}