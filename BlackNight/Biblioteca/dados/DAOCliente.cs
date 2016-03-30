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
    public class DAOCliente : IDAO<Cliente>
    {
        public SqlCommand comandoSql;
        public Conexao conn;
        private string TABELA = "CLIENTE";
        public List<Cliente> list = new List<Cliente>();

        public void Save(Cliente c)
        {
            string sql;
            try
            {
                //Verifica se a chave primaria existe se não insert se sim update
                if (c.CdCliente == 0)
                {
                    //String de Conexao para insert
                    sql = "INSERT INTO " + TABELA + "(NMCLIENTE, CPFCLIENTE, DTNASCCLIENTE, SXCLIENTE, EMAILCLIENTE, NUMCLIENTE) ";
                    sql += "VALUES (@nmCliente, @cpfCliente, @dtNascCliente, @sxCliente, @emailCliente, @numCliente)";
                }
                else
                {
                    //String de Conexao para update
                    sql = "UPDATE " + TABELA + " SET NMCLIENTE=@nmCliente, CPFCLIENTE=@cpfCliente, DTNASCCLIENTE=@dtNascCliente, SXCLIENTE=@sxCliente, EMAILCLIENTE=@emailCliente, NUMCLIENTE=@numCliente WHERE CDCLIENTE=@cdCliente";
                }
                //Abre a conexao
                conn = new Conexao();
                conn.AbrirConexao();

                //Instrução a ser executada
                comandoSql = new SqlCommand(sql, conn.sqlCon);
                if (c.CdCliente != 0)
                {
                    comandoSql.Parameters.AddWithValue("@cdCliente", c.CdCliente);
                }
                comandoSql.Parameters.AddWithValue("@nmCliente", c.NmCliente);
                comandoSql.Parameters.AddWithValue("@cpfCliente", c.CpfCliente);
                comandoSql.Parameters.AddWithValue("@dtNascCliente", c.DtNascCliente);
                comandoSql.Parameters.AddWithValue("@sxCliente", c.SxCliente);
                comandoSql.Parameters.AddWithValue("@emailCliente", c.EmailCliente);                            
                comandoSql.Parameters.AddWithValue("@numCliente", c.NumCliente);


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
        public void Delete(Cliente c)
        {
            string sql;
            try
            {
                sql = "DELETE FROM " + TABELA + " WHERE CDCLIENTE=@cdCliente";

                // Abrir a conexao
                conn = new Conexao();
                conn.AbrirConexao();

                // Instrucao a ser executada
                comandoSql = new SqlCommand(sql, conn.sqlCon);
                comandoSql.Parameters.AddWithValue("@cdCliente", c.CdCliente);
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
        public Cliente getObject(int id)
        {
            Cliente c = new Cliente();
            string sql;
            try
            {
                // String de Conexao
                sql = "SELECT CDCLIENTE, EMAILCLIENTE, NMCLIENTE, DTNASCCLIENTE, SXCLIENTE, NUMCLIENTE FROM " + TABELA;
                sql += " WHERE CDCLIENTE=@cdCliente";

                // Abre a Conexao
                Conexao conn = new Conexao();
                conn.AbrirConexao();
                // Instrucao a ser executada
                comandoSql = new SqlCommand(sql, conn.sqlCon);
                comandoSql.Parameters.AddWithValue("@cdCliente", id);

                // Executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = comandoSql.ExecuteReader();
                // Llendo o resultado da consulta
                while (DbReader.Read())
                {
                    // Acessando os valores das colunas do resultado
                    c.CdCliente = DbReader.GetInt32(DbReader.GetOrdinal("CDCLIENTE"));
                    c.EmailCliente = DbReader.GetString(DbReader.GetOrdinal("EMAILCLIENTE"));
                    c.NmCliente = DbReader.GetString(DbReader.GetOrdinal("NMCLIENTE"));
                    c.DtNascCliente = DbReader.GetDateTime(DbReader.GetOrdinal("DTNASCCLIENTE"));
                    c.SxCliente = DbReader.GetString(DbReader.GetOrdinal("SXCLIENTE"));
                    c.NumCliente = DbReader.GetString(DbReader.GetOrdinal("NUMCLIENTE"));
                }
                // Fechando o leitor de resultados
                DbReader.Close();
                conn.FecharConexao();
                return c;
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar carregar os dados do cliente. Erro = " + ex.Message);
            }

        }
        public List<Cliente> getList()
        {
            Cliente c;
            string sql;
            list.Clear();
            try
            {
                // String de Conexao
                sql = "SELECT CDCLIENTE, NMCLIENTE, CPFCLIENTE, DTNASCCLIENTE, SXCLIENTE, EMAILCLIENTE, NUMCLIENTE FROM " + TABELA;

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
                    c = new Cliente();
                    //acessando os valores das colunas do resultado
                    c.CdCliente = DbReader.GetInt32(DbReader.GetOrdinal("CDCLIENTE"));
                    c.NmCliente = DbReader.GetString(DbReader.GetOrdinal("NMCLIENTE"));
                    c.CpfCliente = DbReader.GetString(DbReader.GetOrdinal("CPFCLIENTE"));
                    c.DtNascCliente = DbReader.GetDateTime(DbReader.GetOrdinal("DTNASCCLIENTE"));
                    c.SxCliente = DbReader.GetString(DbReader.GetOrdinal("SXCLIENTE"));
                    c.EmailCliente = DbReader.GetString(DbReader.GetOrdinal("EMAILCLIENTE"));
                    c.NumCliente = DbReader.GetString(DbReader.GetOrdinal("NUMCLIENTE"));
                    list.Add(c);
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
        public Cliente getObject(int id1, int id2)
        {
            throw new NotImplementedException();
        }

        public DateTime getDate(string nome)
        {
            throw new NotImplementedException();
        }

        public Cliente getPreco(int id, string nome)
        {
            throw new NotImplementedException();
        }

        public Cliente getId(int id, int id2, DateTime dt)
        {
            throw new NotImplementedException();
        }

        public Cliente getId(string nome)
        {
            throw new NotImplementedException();
        }
    }
}

