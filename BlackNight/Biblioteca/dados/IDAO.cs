using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.dados
{
    public interface IDAO<T>
    {
        /// <summary>
        /// Salva os dados de um objeto no banco de dados.
        /// </summary>
        /// <param name="objeto"></param>
        void Save(T obj);

        /// <summary>
        /// Deleta do banco de dados um objeto.
        /// </summary>
        /// <param name="obj"></param>
        void Delete(T obj);

        /// <summary>
        /// Procura no banco de dados por um objeto através do seu id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T getObject(int id);

        /// <summary>
        /// Procura no banco de dados por um objeto através de dois parametros
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T getObject(int id1, int id2);

        /// <summary>
        /// Lista todos os objetos que existem no banco de dados.
        /// </summary>
        /// <returns></returns>

        DateTime getDate(string nome);

        T getPreco(int id, string tipoIngresso);
        List<T> getList();

        T getId(int id, int id2, DateTime dt);

        T getId(string nome);
    }
}
