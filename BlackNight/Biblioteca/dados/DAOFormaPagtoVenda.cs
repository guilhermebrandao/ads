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
    public class DAOFormaPagtoVenda : IDAO<FormaPagtoVenda>
    {
        public SqlCommand comandoSql;
        public Conexao conn;
        private string TABELA = "FORMAPAGTOVENDA";
        public List<FormaPagtoVenda> list = new List<FormaPagtoVenda>();

        public void Save(FormaPagtoVenda fpv)
        {
            string sql;
            try
            {
                //Verifica se a chave primaria existe se não insert se sim update
                if (fpv.CdEvento.CdEvento == 0 && fpv.CdFormaPagto.CdFormaPagto == 0)
                {
                    //String de Conexao para insert
                    sql = "INSERT INTO " + TABELA + "(VLPAGO, CDFORMAPAGTO, CDEVENTO) ";
                    sql += "VALUES (@vlPago, @cdFormaPagto, @cdEvento)";
                }
                else
                {
                    //String de Conexao para update
                    sql = "UPDATE " + TABELA + " SET VLPAGO=@vlPago, CDFORMAPAGTO=@cdFormaPagto, CDEVENTO=@cdEvento WHERE CDFORMAPAGTO=@cdFORMAPAGTO and CDEVENTO=@cdEvento; ";
                }
                //Abre a conexao
                conn = new Conexao();
                conn.AbrirConexao();

                //Instrução a ser executada
                comandoSql = new SqlCommand(sql, conn.sqlCon);
                if (fpv.CdFormaPagto.CdFormaPagto != 0 && fpv.CdEvento.CdEvento != 0)
                {
                    comandoSql.Parameters.AddWithValue("@cdEvento", fpv.CdEvento.CdEvento);
                    comandoSql.Parameters.AddWithValue("@cdRitmo", fpv.CdFormaPagto.CdFormaPagto);
                }
                comandoSql.Parameters.AddWithValue("@vlPago", fpv.VlPago);
                

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
            };
        }
        public void Delete(FormaPagtoVenda fpv)
        {
            string sql;
            try
            {
                sql = "DELETE FROM " + TABELA + "WHERE CDFORMAPAGTO=@cdFormaPagto AND CDEVENTO=@cdEvento";

                // Abrir a conexao
                conn = new Conexao();
                conn.AbrirConexao();

                // Instrucao a ser executada
                comandoSql = new SqlCommand(sql, conn.sqlCon);
                comandoSql.Parameters.AddWithValue("@cdFormaPagto", fpv.CdFormaPagto.CdFormaPagto);
                comandoSql.Parameters.AddWithValue("@cdEvento", fpv.CdEvento.CdEvento);
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
        public FormaPagtoVenda getObject(int id)
        {
            FormaPagtoVenda fpv = new FormaPagtoVenda();
            string sql;
            try
            {
                // String de Conexao
                sql = "SELECT VLPAGO, CDFORMAPGTO, CDEVENTO FROM " + TABELA;
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
                    fpv.VlPago = DbReader.GetFloat(DbReader.GetOrdinal("VLPAGO"));
                    fpv.CdFormaPagto.CdFormaPagto = DbReader.GetInt32(DbReader.GetOrdinal("CDFORMAPAGTO"));
                    fpv.CdEvento.CdEvento = DbReader.GetInt32(DbReader.GetOrdinal("CDEVENTO"));
                }
                // Fechando o leitor de resultados
                DbReader.Close();
                conn.FecharConexao();
                return fpv;
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar carregar os dados da Forma de Pagamento. Erro = " + ex.Message);
            }
        }
        public List<FormaPagtoVenda> getList()
        {
            FormaPagtoVenda fpv = new FormaPagtoVenda();
            string sql;
            list.Clear();
            try
            {
                // String de Conexao
                sql = "SELECT VLPAGO, CDFORMAPAGTO, CDEVENTO FROM " + TABELA;

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
                    fpv.VlPago = DbReader.GetFloat(DbReader.GetOrdinal("VLPAGO"));
                    fpv.CdFormaPagto.CdFormaPagto = DbReader.GetInt32(DbReader.GetOrdinal("CDRITMO"));
                    fpv.CdEvento.CdEvento = DbReader.GetInt32(DbReader.GetOrdinal("CDEVENTO"));
                    list.Add(fpv);
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
        public FormaPagtoVenda getObject(int id1, int id2)
        {
            throw new NotImplementedException();
        }
        public DateTime getDate(string nome)
        {
            throw new NotImplementedException();
        }
        public FormaPagtoVenda getPreco(int id, string tipoIngresso)
        {
            throw new NotImplementedException();
        }

        public FormaPagtoVenda getId(int id, int id2, DateTime dt)
        {
            throw new NotImplementedException();
        }

        public FormaPagtoVenda getId(string nome)
        {
            FormaPagtoVenda fpv = new FormaPagtoVenda();
            string sql;
            try
            {
                // String de Conexao
                sql = "SELECT VLPAGO, CDFORMAPGTO, CDEVENTO FROM " + TABELA;
                sql += " WHERE CDEVENTO=@cdEvento";

                // Abre a Conexao 
                Conexao conn = new Conexao();
                conn.AbrirConexao();
                // Instrucao a ser executada
                comandoSql = new SqlCommand(sql, conn.sqlCon);
                comandoSql.Parameters.AddWithValue("@cdEvento", nome);

                // Executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = comandoSql.ExecuteReader();
                // Llendo o resultado da consulta
                while (DbReader.Read())
                {
                    // Acessando os valores das colunas do resultado
                    fpv.VlPago = DbReader.GetFloat(DbReader.GetOrdinal("VLPAGO"));
                    fpv.CdFormaPagto.CdFormaPagto = DbReader.GetInt32(DbReader.GetOrdinal("CDFORMAPAGTO"));
                    fpv.CdEvento.CdEvento = DbReader.GetInt32(DbReader.GetOrdinal("CDEVENTO"));
                }
                // Fechando o leitor de resultados
                DbReader.Close();
                conn.FecharConexao();
                return fpv;
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar carregar os dados da Forma de Pagamento. Erro = " + ex.Message);
            }
        }
    }
}
