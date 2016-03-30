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
    public class DAORitmo : IDAO<Ritmo>
    {
        public SqlCommand comandoSql;
        public Conexao conn;
        private string TABELA = "RITMO";
        public List<Ritmo> list = new List<Ritmo>();
        public void Save(Ritmo r)
        {
            string sql;
            try
            {
                //Verifica se a chave primaria existe se não insert se sim update
                if (r.CdRitmo == 0)
                {
                    //String de Conexao para insert
                    sql = "INSERT INTO " + TABELA + "(NMRITMO) ";
                    sql += "VALUES (@nmRitmo)";
                }
                else
                {
                    //String de Conexao para update
                    sql = "UPDATE " + TABELA + " SET NMRITMO=@nmRitmo WHERE CDRITMO=@cdRitmo; ";
                }
                //Abre a conexao
                conn = new Conexao();
                conn.AbrirConexao();

                //Instrução a ser executada
                comandoSql = new SqlCommand(sql, conn.sqlCon);
                if (r.CdRitmo != 0)
                {
                    comandoSql.Parameters.AddWithValue("@cdRitmo", r.CdRitmo);
                }
                comandoSql.Parameters.AddWithValue("@nmRitmo", r.NmRitmo);

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
        public void Delete(Ritmo r)
        {
            string sql;
            try
            {
                sql = "DELETE FROM " + TABELA + " WHERE CDRITMO = @cdRitmo";

                // Abre a Conexao
                Conexao conn = new Conexao();
                conn.AbrirConexao();
                // Instrucao a ser executada
                comandoSql = new SqlCommand(sql, conn.sqlCon);
                comandoSql.Parameters.AddWithValue("@cdRitmo", r.CdRitmo);
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
        public Ritmo getObject(int id)
        {
            Ritmo r = new Ritmo();
            string sql;
            try
            {
                // String de Conexao
                sql = "SELECT CDRITMO, NMRITMO FROM " + TABELA;
                sql += " WHERE CDRITMO = @cdRitmo";

                // Abre a Conexao
                Conexao conn = new Conexao();
                conn.AbrirConexao();
                // Instrucao a ser executada
                comandoSql = new SqlCommand(sql, conn.sqlCon);
                comandoSql.Parameters.AddWithValue("@cdRitmo", id);

                // Executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = comandoSql.ExecuteReader();
                // Llendo o resultado da consulta
                while (DbReader.Read())
                {
                    // Acessando os valores das colunas do resultado
                    r.CdRitmo = DbReader.GetInt32(DbReader.GetOrdinal("CDRITMO"));
                    r.NmRitmo = DbReader.GetString(DbReader.GetOrdinal("NMRITMO"));
                }
                // Fechando o leitor de resultados
                DbReader.Close();
                conn.FecharConexao();
                return r;
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar carregar os dados do Evento. Erro = " + ex.Message);
            }
        }
        public List<Ritmo> getList()
        {
            Ritmo r;
            string sql;
            list.Clear();
            try
            {
                // String de Conexao
                sql = "SELECT CDRITMO, NMRITMO FROM " + TABELA;

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
                    r = new Ritmo();
                    //acessando os valores das colunas do resultado
                    r.CdRitmo = DbReader.GetInt32(DbReader.GetOrdinal("CDRITMO"));
                    r.NmRitmo = DbReader.GetString(DbReader.GetOrdinal("NMRITMO"));
                    list.Add(r);
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
        public Ritmo getObject(int id1, int id2)
        {
            throw new NotImplementedException();
        }
        public DateTime getDate(string nome)
        {
            throw new NotImplementedException();
        }
        public Ritmo getPreco(int id, string tipoIngresso)
        {
            throw new NotImplementedException();
        }
        public Ritmo getId(int id, int id2, DateTime dt)
        {
            throw new NotImplementedException();
        }
        public Ritmo getId(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
