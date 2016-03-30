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
    public class DAOAtracao : IDAO<Atracao>
    {
        public SqlCommand comandoSql;
        public Conexao conn;
        private string TABELA = "ATRACAO";
        public List<Atracao> list = new List<Atracao>();
        public void Save(Atracao a)
        {
            string sql;
            try
            {
                //Verifica se a chave primaria existe se não insert se sim update
                if (a.CdAtracao == 0)
                {
                    //String de Conexao para insert
                    sql = "INSERT INTO " + TABELA + "(NMATRACAO, NUMATRACAO) ";
                    sql += "VALUES (@nmAtracao, @numAtracao)";
                }
                else
                {
                    //String de Conexao para update
                    sql = "UPDATE " + TABELA + " SET NMATRACAO=@nmAtracao, NUMATRACAO=@numAtracao WHERE CDATRACAO=@cdAtracao; ";
                }
                //Abre a conexao
                conn = new Conexao();
                conn.AbrirConexao();

                //Instrução a ser executada
                comandoSql = new SqlCommand(sql, conn.sqlCon);
                if (a.CdAtracao != 0)
                {
                    comandoSql.Parameters.AddWithValue("@cdAtracao", a.CdAtracao);
                }
                comandoSql.Parameters.AddWithValue("@nmAtracao", a.NmAtracao);
                comandoSql.Parameters.AddWithValue("@numAtracao", a.NumAtracao);

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
        public void Delete(Atracao a)
        {
            string sql;
            try
            {
                sql = "DELETE FROM " + TABELA + " WHERE CDATRACAO = @cdAtracao";

                // Abrir a conexao
                conn = new Conexao();
                conn.AbrirConexao();

                // Instrucao a ser executada
                comandoSql = new SqlCommand(sql, conn.sqlCon);
                comandoSql.Parameters.AddWithValue("@cdAtracao", a.CdAtracao);
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
        public List<Atracao> getList()
        {
            Atracao a;
            string sql;
            list.Clear();
            try
            {
                // String de Conexao
                sql = "SELECT CDATRACAO, NMATRACAO, NUMATRACAO FROM " + TABELA;

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
                    a = new Atracao();
                    //acessando os valores das colunas do resultado
                    a.CdAtracao = DbReader.GetInt32(DbReader.GetOrdinal("CDATRACAO"));
                    a.NmAtracao = DbReader.GetString(DbReader.GetOrdinal("NMATRACAO"));
                    a.NumAtracao = DbReader.GetString(DbReader.GetOrdinal("NUMATRACAO"));
                    list.Add(a);
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
        public Atracao getObject(int id)
        {
            Atracao a = new Atracao();
            string sql;
            try
            {
                // String de Conexao
                sql = "SELECT CDATRACAO, NMATRACAO, NUMATRACAO FROM " + TABELA;
                sql += " WHERE CDATRACAO=@cdAtracao";

                // Abre a Conexao
                Conexao conn = new Conexao();
                conn.AbrirConexao();
                // Instrucao a ser executada
                comandoSql = new SqlCommand(sql, conn.sqlCon);
                comandoSql.Parameters.AddWithValue("@cdAtracao", id);

                // Executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = comandoSql.ExecuteReader();
                // Llendo o resultado da consulta
                while (DbReader.Read())
                {
                    // Acessando os valores das colunas do resultado
                    a.CdAtracao = DbReader.GetInt32(DbReader.GetOrdinal("CDATRACAO"));
                    a.NmAtracao = DbReader.GetString(DbReader.GetOrdinal("NMATRACAO"));
                    a.NumAtracao = DbReader.GetString(DbReader.GetOrdinal("NUMATRACAO"));
                }
                // Fechando o leitor de resultados
                DbReader.Close();
                conn.FecharConexao();
                return a;
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar carregar os dados da Venda. Erro = " + ex.Message);
            }
        }
        public Atracao getObject(int id1, int id2)
        {
            throw new NotImplementedException();
        }
        public DateTime getDate(string nome)
        {
            throw new NotImplementedException();
        }
        public Atracao getPreco(int id, string nome, string tipoIngresso)
        {
            throw new NotImplementedException();
        }
        public Atracao getPreco(int id, string tipoIngresso)
        {
            id = 0;
            Atracao a = new Atracao();
            string sql;
            try
            {
                // String de Conexao
                sql = "SELECT CDATRACAO, NMATRACAO, NUMATRACAO FROM " + TABELA;
                sql += " WHERE NMATRACAO=@nmAtracao)";

                // Abre a Conexao
                Conexao conn = new Conexao();
                conn.AbrirConexao();
                // Instrucao a ser executada
                comandoSql = new SqlCommand(sql, conn.sqlCon);
                comandoSql.Parameters.AddWithValue("@nmAtracao", tipoIngresso);

                // Executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = comandoSql.ExecuteReader();
                // Llendo o resultado da consulta
                while (DbReader.Read())
                {
                    // Acessando os valores das colunas do resultado
                    a.CdAtracao = DbReader.GetInt32(DbReader.GetOrdinal("CDATRACAO"));
                    a.NmAtracao = DbReader.GetString(DbReader.GetOrdinal("NMATRACAO"));
                    a.NumAtracao = DbReader.GetString(DbReader.GetOrdinal("NUMATRACAO"));
                }
                // Fechando o leitor de resultados
                DbReader.Close();
                conn.FecharConexao();
                return a;
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar carregar os dados da Venda. Erro = " + ex.Message);
            }
        }
        public Atracao getId(int id, int id2, DateTime dt)
        {
            throw new NotImplementedException();
        }
        public Atracao getId(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
