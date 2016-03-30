using Biblioteca.Basicas;
using Biblioteca.erros;
using Biblioteca.util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.dados
{
    public class DAOVenda : IDAO<Venda>
    {
        public SqlCommand comandoSql;
        public Conexao conn;
        private string TABELA = "VENDA";
        public List<Venda> list = new List<Venda>();
        public void Save(Venda v)
        {
            string sql;
            try
            {
                if (v.CdVenda == 0)
                {
                    //String de Conexao para insert
                    sql = "INSERT INTO " + TABELA + "(HRVENDA, CDCLIENTE, CDEVENTO) ";
                    sql += "values(@hrVenda, @cdCliente, @cdEvento)";
                }
                else
                {
                    //String de Conexao para update
                    sql = "UPDATE " + TABELA + " set HRVENDA=@hrVenda, CDCLIENTE=@cdCliente, CDEVENTO=@cdEvento; ";
                }
                conn = new Conexao();
                conn.AbrirConexao();

                //Instrução a ser executada
                comandoSql = new SqlCommand(sql, conn.sqlCon);
                if (v.CdVenda != 0)
                {
                    comandoSql.Parameters.AddWithValue("@cdVenda", v.CdVenda);
                }
                comandoSql.Parameters.AddWithValue("@hrVenda", v.DtVenda);
                comandoSql.Parameters.AddWithValue("@cdCliente", v.CdCliente.CdCliente);
                comandoSql.Parameters.AddWithValue("@cdEvento", v.CdEvento.CdEvento);

                //executa o procedimento no banco
                comandoSql.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new DAOException("Erro ao tentar salvar. Erro = " + ex.Message);
            }
            finally
            {
                conn.FecharConexao();
            }
        }
        public void Delete(Venda v)
        {
            string sql;
            try
            {
                sql = "DELETE FROM " + TABELA + "WHERE (CDVENDA)=(@cdVenda))";

                // Abrir a conexao
                conn = new Conexao();
                conn.AbrirConexao();

                // Instrucao a ser executada
                comandoSql = new SqlCommand(sql, conn.sqlCon);
                comandoSql.Parameters.AddWithValue("@cdVenda", v.CdVenda);
                // Executa o procedimento no banco
                comandoSql.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                throw new DAOException("Erro ao tentar deletar. Erro=" + ex.Message);
            }
            finally
            {
                conn.FecharConexao();
            }
        }
        public List<Venda> getList()
        {
            Venda v = new Venda();
            string sql;
            list.Clear();
            try
            {
                // String de Conexao
                sql = "SELECT CDVENDA, HRVENDA, CDEVENTO, CDCLIENTE FROM " + TABELA;

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
                    //acessando os valores das colunas do resultado
                    v.CdVenda = DbReader.GetInt32(DbReader.GetOrdinal("CDVENDA"));
                    v.DtVenda = DbReader.GetDateTime(DbReader.GetOrdinal("HRVENDA"));
                    v.CdCliente.CdCliente = DbReader.GetInt32(DbReader.GetOrdinal("CDCLIENTE"));
                    v.CdEvento.CdEvento = DbReader.GetInt32(DbReader.GetOrdinal("CDEVENTO"));
                    list.Add(v);
                }
                //fechando o leitor de resultados
                DbReader.Close();

                return list;
            }
            catch (SqlException ex)
            {
                throw new DAOException("Erro ao tentar listar. Erro = " + ex.Message);
            }
            finally
            {
                conn.FecharConexao();
            }
        }
        public Venda getObject(int id)
        {
            Venda v = new Venda();
            string sql;
            try
            {
                // String de Conexao
                sql = "SELECT CDVENDA, HRVENDA, CDCLIENTE, CDEVENTO FROM " + TABELA;
                sql += " WHERE CDVENDA=@cdVenda";

                // Abre a Conexao
                Conexao conn = new Conexao();
                conn.AbrirConexao();
                // Instrucao a ser executada
                comandoSql = new SqlCommand(sql, conn.sqlCon);
                comandoSql.Parameters.AddWithValue("@cdVenda", id);

                // Executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = comandoSql.ExecuteReader();
                // Llendo o resultado da consulta
                while (DbReader.Read())
                {
                    // Acessando os valores das colunas do resultado
                    v.CdVenda = DbReader.GetInt32(DbReader.GetOrdinal("CDVENDA"));
                    v.DtVenda = DbReader.GetDateTime(DbReader.GetOrdinal("HRVENDA"));
                    v.CdCliente.CdCliente = DbReader.GetInt32(DbReader.GetOrdinal("CDCLIENTE"));
                    v.CdEvento.CdEvento = DbReader.GetInt32(DbReader.GetOrdinal("CDEVENTO"));
                }
                // Fechando o leitor de resultados
                DbReader.Close();
                conn.FecharConexao();
                return v;
            }

            catch (SqlException ex)
            {
                throw new DAOException("Erro ao tentar carregar os dados da Venda. Erro = " + ex.Message);
            }
            finally
            {

            }
        }
        public Venda getObject(int idE, int idC)
        {
            Venda v = new Venda();
            string sql;
            try
            {
                // String de Conexao
                sql = "SELECT CDVENDA, HRVENDA, CDCLIENTE, CDEVENTO FROM " + TABELA;
                sql += " WHERE CDEVENTO=@cdEvento AND CDCLIENTE=@cdCliente";

                // Abre a Conexao
                Conexao conn = new Conexao();
                conn.AbrirConexao();
                // Instrucao a ser executada
                comandoSql = new SqlCommand(sql, conn.sqlCon);
                comandoSql.Parameters.AddWithValue("@cdEvento", idE);
                comandoSql.Parameters.AddWithValue("@cdCliente", idC);
                

                // Executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = comandoSql.ExecuteReader();
                // Llendo o resultado da consulta
                while (DbReader.Read())
                {
                    // Acessando os valores das colunas do resultado
                    v.CdVenda = DbReader.GetInt32(DbReader.GetOrdinal("CDVENDA"));
                    v.DtVenda = DbReader.GetDateTime(DbReader.GetOrdinal("HRVENDA"));
                    v.CdCliente.CdCliente = DbReader.GetInt32(DbReader.GetOrdinal("CDCLIENTE"));
                    v.CdEvento.CdEvento = DbReader.GetInt32(DbReader.GetOrdinal("CDEVENTO"));
                }
                // Fechando o leitor de resultados
                //DbReader.Close();
                conn.FecharConexao();
                return v;
            }

            catch (SqlException ex)
            {
                throw new DAOException("Erro ao tentar carregar os dados da Venda. Erro = " + ex.Message);
            }
        }

        public DateTime getDate(string nome)
        {
            throw new NotImplementedException();
        }

        public Venda getPreco(int id, string tipoIngresso)
        {
            throw new NotImplementedException();
        }
        public Venda getIdVenda (int idCliente, int idEvento, DateTime hrEvento)
        {
            Venda v = new Venda();
            string sql;
            try
            {
                // String de Conexao
                sql = "SELECT CDVENDA, CDEVENTO, CDCLIENTE, HRVENDA FROM " + TABELA;
                sql += " WHERE CDEVENTO=@cdEvento AND CDCLIENTE=@cdCliente AND HREVENTO=@hrEvento";

                // Abre a Conexao
                Conexao conn = new Conexao();
                conn.AbrirConexao();
                // Instrucao a ser executada
                comandoSql = new SqlCommand(sql, conn.sqlCon); 
                comandoSql.Parameters.AddWithValue("@cdEvento", idEvento);
                comandoSql.Parameters.AddWithValue("@cdCliente", idCliente);
                comandoSql.Parameters.AddWithValue("@hrEvento", hrEvento);


                // Executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = comandoSql.ExecuteReader();
                // Llendo o resultado da consulta
                while (DbReader.Read())
                {
                    // Acessando os valores das colunas do resultado
                    v.CdVenda = DbReader.GetInt32(DbReader.GetOrdinal("CDVENDA"));
                    v.DtVenda = DbReader.GetDateTime(DbReader.GetOrdinal("HRVENDA"));
                    v.CdCliente.CdCliente = DbReader.GetInt32(DbReader.GetOrdinal("CDCLIENTE"));
                    v.CdEvento.CdEvento = DbReader.GetInt32(DbReader.GetOrdinal("CDEVENTO"));
                }
                // Fechando o leitor de resultados
                //DbReader.Close();
                conn.FecharConexao();
                return v;
            }

            catch (SqlException ex)
            {
                throw new DAOException("Erro ao tentar carregar os dados da Venda. Erro = " + ex.Message);
            }
        }

        public Venda getId(int id, int id2, DateTime dt)
        {
            throw new NotImplementedException();
        }

        public Venda getId(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
