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
    public class DAORitmoEvento : IDAO<RitmoEvento>
    {
        public SqlCommand comandoSql;
        public Conexao conn;
        private string TABELA = "RITMOEVENTO";
        public List<RitmoEvento> list = new List<RitmoEvento>();

        public void Save(RitmoEvento re)
        {
            string sql;
            try
            {
                //Verifica se a chave primaria existe se não insert se sim update
                if (re.CdRitmo.CdRitmo == 0 && re.CdEvento.CdEvento == 0)
                {
                    //String de Conexao para insert
                    sql = "INSERT INTO " + TABELA + "(CDRITMO, CDEVENTO) ";
                    sql += "VALUES (@cdRitmo, @cdEvento)";
                }
                else
                {
                    //String de Conexao para update
                    sql = "UPDATE " + TABELA + " SET CDRITMO=@cdRitmo, CDEVENTO=@cdEvento WHERE CDRITMO=@cdRitmo and CDEVENTO=@cdEvento; ";
                }
                //Abre a conexao
                conn = new Conexao();
                conn.AbrirConexao();

                //Instrução a ser executada
                comandoSql = new SqlCommand(sql, conn.sqlCon);
                if (re.CdRitmo.CdRitmo != 0 && re.CdEvento.CdEvento != 0)
                {
                    comandoSql.Parameters.AddWithValue("@cdRitmo", re.CdRitmo.CdRitmo);
                }
                comandoSql.Parameters.AddWithValue("@cdEvento", re.CdEvento.CdEvento);

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
        public void Delete(RitmoEvento re)
        {
            string sql;
            try
            {
                sql = "DELETE FROM " + TABELA + "WHERE CDRITMO=@cdRitmo and CDEVENTO=@cdEvento";

                // Abrir a conexao
                conn = new Conexao();
                conn.AbrirConexao();

                // Instrucao a ser executada
                comandoSql = new SqlCommand(sql, conn.sqlCon);
                comandoSql.Parameters.AddWithValue("@cdRitmo", re.CdRitmo.CdRitmo);
                comandoSql.Parameters.AddWithValue("@nmRitmo", re.CdEvento.CdEvento);
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
        public RitmoEvento getObject(int id)
        {
            RitmoEvento re = new RitmoEvento();
            string sql;
            try
            {
                // String de Conexao
                sql = "SELECT CDRITMO, CDEVENTO FROM " + TABELA;
                sql += " WHERE CDEVENTO=@cdEvento";

                // Abre a Conexao 
                Conexao conn = new Conexao();
                conn.AbrirConexao();
                // Instrucao a ser executada
                comandoSql = new SqlCommand(sql, conn.sqlCon);
                comandoSql.Parameters.AddWithValue("@cdEvento", id);

                // Executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = comandoSql.ExecuteReader();
                // Llendo o resultado da consulta
                while (DbReader.Read())
                {
                    // Acessando os valores das colunas do resultado
                    re.CdRitmo.CdRitmo = DbReader.GetInt32(DbReader.GetOrdinal("CDRITMO"));
                    re.CdEvento.CdEvento = DbReader.GetInt32(DbReader.GetOrdinal("CDEVENTO"));
                }
                // Fechando o leitor de resultados
                DbReader.Close();
                conn.FecharConexao();

                return re;
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar carregar os dados da Venda. Erro = " + ex.Message);
            }
        }
        public List<RitmoEvento> getList()
        {
            RitmoEvento re = new RitmoEvento();
            string sql;
            list.Clear();
            try
            {
                // String de Conexao
                sql = "SELECT CDRITMO, CDEVENTO FROM" + TABELA;

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
                    re.CdRitmo.CdRitmo = DbReader.GetInt32(DbReader.GetOrdinal("CDRITMO"));
                    re.CdEvento.CdEvento = DbReader.GetInt32(DbReader.GetOrdinal("CDEVENTO"));
                    list.Add(re);
                }
                //fechando o leitor de resultados
                DbReader.Close();

                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar listar. Erro = " + ex.Message);
            }
            finally
            {
                conn.FecharConexao();
            }
        }
        public RitmoEvento getObject(int id1, int id2)
        {
            throw new NotImplementedException();
        }

        public DateTime getDate(string nome)
        {
            throw new NotImplementedException();
        }

        public RitmoEvento getPreco(int id, string tipoIngresso)
        {
            throw new NotImplementedException();
        }

        public RitmoEvento getId(int id, int id2, DateTime dt)
        {
            throw new NotImplementedException();
        }

        public RitmoEvento getId(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
