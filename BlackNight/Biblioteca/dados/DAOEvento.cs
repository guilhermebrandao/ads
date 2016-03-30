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
    class DAOEvento : IDAO<Evento>
    {
        public SqlCommand comandoSql;
        public Conexao conn;
        private string tabela = "EVENTO";
        public List<Evento> list = new List<Evento>();
        public void Save(Evento e)
        {
            string sql;
            try
            {
                //Verifica se a chave primaria existe se não insert se sim update
                if (e.CdEvento == 0)
                {
                    //String de Conexao para insert
                    sql = "insert into " + tabela + "(CDATRACAO, QTDINGFEM, VLINGMASC, QTDINGMASC, VLINGFEM, DTEVENTO) ";
                    sql += "values(@cdAtracao, @qtdIngFem, @vlIngMasc, @qtdIngMasc, @vlIngFem, @dtEvento)";
                }
                else
                {
                    //String de Conexao para update
                    sql = "update " + tabela + " set CDATRACAO=@cdAtracao,QTDINGFEM=@qtdIngFem,VLINGMASC=@vlIngMasc, QTDINGMASC=@qtdIngMasc, VLINGFEM=@vlIngFem, DTEVENTO=@dtEvento where CDEVENTO=@cdEvento; ";
                }
                //Abre a conexao
                conn = new Conexao();
                conn.AbrirConexao();

                //Instrução a ser executada
                comandoSql = new SqlCommand(sql, conn.sqlCon);
                if (e.CdEvento != 0)
                {
                    comandoSql.Parameters.AddWithValue("@cdEvento", e.CdEvento);
                }
                comandoSql.Parameters.AddWithValue("@cdAtracao", e.CdAtracao);
                comandoSql.Parameters.AddWithValue("@qtdIngFem", e.QtdIngFem);
                comandoSql.Parameters.AddWithValue("@vlIngMasc", e.VlIngMasc);
                comandoSql.Parameters.AddWithValue("@qtdIngMasc", e.QtdIngMasc);
                comandoSql.Parameters.AddWithValue("@vlIngFem", e.VlIngFem);
                comandoSql.Parameters.AddWithValue("@dtEvento", e.DtEvento);

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
        public void Delete(Evento e)
        {
            string sql;
            try
            {
                sql = "DELETE FROM " + tabela + " WHERE CDEVENTO = @cdEvento";

                // Abre a Conexao
                Conexao conn = new Conexao();
                conn.AbrirConexao();
                // Instrucao a ser executada
                comandoSql = new SqlCommand(sql, conn.sqlCon);
                comandoSql.Parameters.AddWithValue("@cdEvento", e.CdEvento);
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
        public Evento getObject(int id)
        {
            Evento e = new Evento();
            string sql;
            try
            {
                // String de Conexao
                sql = "SELECT CDEVENTO, NMEVENTO, DTEVENTO, CDATRACAO, QTDINGFEM, QTDINGMASC, VLINGFEM, VLINGMASC FROM " + tabela;
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
                    e.CdEvento = DbReader.GetInt32(DbReader.GetOrdinal("CDEVENTO"));
                    e.NmEvento = DbReader.GetString(DbReader.GetOrdinal("NMEVENTO"));
                    e.CdAtracao.CdAtracao = DbReader.GetInt32(DbReader.GetOrdinal("CDATRACAO"));
                    e.DtEvento = DbReader.GetDateTime(DbReader.GetOrdinal("DTEVENTO"));
                    e.QtdIngFem = DbReader.GetInt32(DbReader.GetOrdinal("QTDINGFEM"));
                    e.QtdIngMasc = DbReader.GetInt32(DbReader.GetOrdinal("QTDINGMASC"));
                    e.VlIngFem = DbReader.GetDecimal(DbReader.GetOrdinal("VLINGFEM"));
                    e.VlIngMasc = DbReader.GetDecimal(DbReader.GetOrdinal("VLINGMASC"));
                }
                // Fechando o leitor de resultados
                DbReader.Close();
                conn.FecharConexao();
                return e;
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar carregar os dados do Evento. Erro = " + ex.Message);
            }


        }
        public List<Evento> getList()
        {
            Evento e; 
            string sql;
            list.Clear();
            try
            {
                // String de Conexao
                sql = "SELECT CDEVENTO, CDATRACAO, NMEVENTO, DTEVENTO, QTDINGFEM, VLINGFEM, VLINGMASC, QTDINGMASC FROM " + tabela;

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
                    e = new Evento();
                    //acessando os valores das colunas do resultado
                    e.CdEvento = DbReader.GetInt32(DbReader.GetOrdinal("CDEVENTO"));
                    //e.CdAtracao.CdAtracao = DbReader.GetInt32(DbReader.GetOrdinal("CDATRACAO"));
                    e.NmEvento = DbReader.GetString(DbReader.GetOrdinal("NMEVENTO"));                    
                    e.DtEvento = DbReader.GetDateTime(DbReader.GetOrdinal("DTEVENTO"));
                    e.QtdIngFem = DbReader.GetInt32(DbReader.GetOrdinal("QTDINGFEM"));
                    e.QtdIngMasc = DbReader.GetInt32(DbReader.GetOrdinal("QTDINGMASC"));
                    e.VlIngFem = DbReader.GetDecimal(DbReader.GetOrdinal("VLINGFEM"));
                    e.VlIngMasc = DbReader.GetDecimal(DbReader.GetOrdinal("VLINGMASC"));
                    list.Add(e);

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
            finally
            {
                
            }
        }
        public Evento getObject(int id1, int id2)
        {
            throw new NotImplementedException();
        }
        public DateTime getDate(string nome)
        {
            Evento e = new Evento();
            string sql;
            try
            {
                // String de Conexao
                sql = "SELECT DTEVENTO FROM " + tabela;
                sql += " WHERE NMEVENTO=@nmEvento";

                // Abre a Conexao
                Conexao conn = new Conexao();
                conn.AbrirConexao();
                // Instrucao a ser executada
                comandoSql = new SqlCommand(sql, conn.sqlCon);
                comandoSql.Parameters.AddWithValue("@nmEvento", nome);

                // Executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = comandoSql.ExecuteReader();
                // Llendo o resultado da consulta
                while (DbReader.Read())
                {
                    // Acessando os valores das colunas do resultado
                    e.DtEvento = DbReader.GetDateTime(DbReader.GetOrdinal("DTEVENTO"));
                }
                // Fechando o leitor de resultados
                DbReader.Close();
                conn.FecharConexao();
                return e.DtEvento;
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar carregar os dados do Evento. Erro = " + ex.Message);
            }

        }
        public Evento getPreco(int id, string nome)
        {
            Evento e = new Evento();
            string sql;
            try
            {
            
                    sql = "SELECT VLINGMASC FROM " + tabela;
                    sql += " WHERE CD";
              
                // String de Conexao
                

                // Abre a Conexao
                Conexao conn = new Conexao();
                conn.AbrirConexao();
                // Instrucao a ser executada
                comandoSql = new SqlCommand(sql, conn.sqlCon);
                comandoSql.Parameters.AddWithValue("@nmEvento", nome);

                // Executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = comandoSql.ExecuteReader();
                // Llendo o resultado da consulta
                while (DbReader.Read())
                {
                    // Acessando os valores das colunas do resultado
                    e.DtEvento = DbReader.GetDateTime(DbReader.GetOrdinal("DTEVENTO"));
                }
                // Fechando o leitor de resultados
                DbReader.Close();
                conn.FecharConexao();
                return e;
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar carregar os dados do Evento. Erro = " + ex.Message);
            }

        }
        public Evento getId(int id, int id2, DateTime dt)
        {
            throw new NotImplementedException();
        }
        public Evento getId(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
