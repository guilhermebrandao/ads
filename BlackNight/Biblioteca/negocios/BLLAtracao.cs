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
    public class BLLAtracao
    {
        public readonly IDAO<Atracao> dao;

        public BLLAtracao()
        {
            dao = new DAOAtracao();
        }
        public void Inserir(Atracao a)
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
        public void Alterar(Atracao a)
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
        public void Excluir(Atracao a)
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
        public List<Atracao> Listar()
        {
            return dao.getList();
        }
        public DateTime ProcurarData(string nome)
        {
            return dao.getDate(nome);
        }
        public Atracao ProcurarPreco(int id, string tipoIngresso)
        {
            return dao.getPreco(id, tipoIngresso);
        }
        public Atracao ProcurarEvento(int id)
        {
            return dao.getObject(id);
        }
    }
}

