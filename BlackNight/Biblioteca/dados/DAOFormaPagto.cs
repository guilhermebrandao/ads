using Biblioteca.Basicas;
using Biblioteca.util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.dados
{
    public class DAOFormaPagto : IDAO<FormaPagto>
    {
        public SqlCommand comandoSql;
        public Conexao conn;
        private string TABELA = "FORMAPAGTO";
        public List<FormaPagto> list = new List<FormaPagto>();

        public void Save(FormaPagto fp)
        {
            string sql;
            try
            {
                //Verifica se a chave primaria existe se não insert se sim update
                if (fp.CdFormaPagto == 0)
                {
                    //String de Conexao para insert
                    sql = "INSERT INTO " + TABELA + "(DESCFORMAPAGTO) ";
                    sql += "VALUES (@descFormaPagto)";
                }
                else
                {
                    //String de Conexao para update
                    sql = "UPDATE " + TABELA + " SET DESCFORMAPAGTO WHERE CDFORMAPAGTO=@cdFormaPagto";
                }
                //Abre a conexao
                conn = new Conexao();
                conn.AbrirConexao();

                //Instrução a ser executada
                comandoSql = new SqlCommand(sql, conn.sqlCon);
                if (fp.CdFormaPagto != 0)
                {
                    comandoSql.Parameters.AddWithValue("@cdRitmo", fp.CdFormaPagto);
                }
                comandoSql.Parameters.AddWithValue("@descPagto", fp.DescFormaPagto);

                //executa o procedimento no banco
                comandoSql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar salvar. Erro = " + ex.Message);
            }
            finally
            {
                conn.FecharConexao();
            }
        }
        public void Delete(FormaPagto fp)
        {
            string sql;
            try
            {
                sql = "DELETE FROM " + TABELA + " WHERE CDFORMAPAGTO=@cdFormaPagto";

                // Abrir a conexao
                conn = new Conexao();
                conn.AbrirConexao();

                // Instrucao a ser executada
                comandoSql = new SqlCommand(sql, conn.sqlCon);
                comandoSql.Parameters.AddWithValue("@cdFormaPagto", fp.CdFormaPagto);
                // Executa o procedimento no banco
                comandoSql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao tentar deletar. Erro=" + ex.Message);
            }
            finally
            {
                conn.FecharConexao();
            }
        }
        public FormaPagto getObject(int id)
        {
            FormaPagto fp = new FormaPagto();
            string sql;
            try
            {
                // String de Conexao
                sql = "SELECT CDFORMAPAGTO, DESCFORMAPAGTO FROM " + TABELA;
                sql += " WHERE CDFORMAPAGTO=@cdFormaPagto";

                // Abre a Conexao
                Conexao conn = new Conexao();
                conn.AbrirConexao();
                // Instrucao a ser executada
                comandoSql = new SqlCommand(sql, conn.sqlCon);
                comandoSql.Parameters.AddWithValue("@cdFormaPagto", id);

                // Executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = comandoSql.ExecuteReader();
                // Llendo o resultado da consulta
                while (DbReader.Read())
                {
                    // Acessando os valores das colunas do resultado
                    fp.CdFormaPagto = DbReader.GetInt32(DbReader.GetOrdinal("CDFORMAPAGTO"));
                    fp.DescFormaPagto = DbReader.GetString(DbReader.GetOrdinal("DESCFORMAPAGTO"));
                }
                // Fechando o leitor de resultados
                DbReader.Close();
                conn.FecharConexao();
                return fp;
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar carregar os dados da Venda. Erro = " + ex.Message);
            }
        }
        public List<FormaPagto> getList()
        {
            FormaPagto fp;
            string sql;
            list.Clear();
            try
            {
                
                // String de Conexao
                sql = "SELECT CDFORMAPAGTO, DESCFORMAPAGTO FROM " + TABELA ;

                // Abre a Conexao
                Conexao conn = new Conexao();
                conn.AbrirConexao();
                // Instrucao a ser executada
                comandoSql = new SqlCommand(sql, conn.sqlCon);
                // Executando a instrução e colocando o resultado em um leitor
                SqlDataReader DbReader = comandoSql.ExecuteReader();

                // Lendo o resultado da consulta
                while (DbReader.Read())
                {
                    fp = new FormaPagto();
                    //acessando os valores das colunas do resultado
                    fp.CdFormaPagto = DbReader.GetInt32(DbReader.GetOrdinal("CDFORMAPAGTO"));
                    fp.DescFormaPagto = DbReader.GetString(DbReader.GetOrdinal("DESCFORMAPAGTO"));
                    list.Add(fp);
                }
                //fechando o leitor de resultados
                DbReader.Close();
                conn.FecharConexao();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar listar. Erro = " + ex.Message);
            }

        }
        public FormaPagto getObject(int id1, int id2)
        {
            throw new NotImplementedException();
        }

        public DateTime getDate(string nome)
        {
            throw new NotImplementedException();
        }

        public FormaPagto getPreco(int id, string tipoIngresso)
        {
            throw new NotImplementedException();
        }

        public FormaPagto getId(int id, int id2, DateTime dt)
        {
            throw new NotImplementedException();
        }

        public FormaPagto getId(string nome)
        {
            FormaPagto fp = new FormaPagto();
            string sql;
            try
            {
                // String de Conexao
                sql = "SELECT CDFORMAPAGTO, DESCFORMAPAGTO FROM " + TABELA;
                sql += " WHERE DESCFORMAPAGTO=@descFormaPagto ";

                // Abre a Conexao
                Conexao conn = new Conexao();
                conn.AbrirConexao();
                // Instrucao a ser executada
                comandoSql = new SqlCommand(sql, conn.sqlCon);
                comandoSql.Parameters.AddWithValue("@descFormaPagto", nome);

                // Executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = comandoSql.ExecuteReader();
                // Llendo o resultado da consulta
                while (DbReader.Read())
                {
                    // Acessando os valores das colunas do resultado
                    fp.CdFormaPagto = DbReader.GetInt32(DbReader.GetOrdinal("CDFORMAPAGTO"));
                    fp.DescFormaPagto = DbReader.GetString(DbReader.GetOrdinal("DESCFORMAPAGTO"));
                }
                // Fechando o leitor de resultados
                DbReader.Close();
                conn.FecharConexao();
                return fp;
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar carregar os dados da Venda. Erro = " + ex.Message);
            }
        }
    }
}
