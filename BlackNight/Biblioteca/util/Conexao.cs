using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.util
{
    public class Conexao : IConexao
    {
        public SqlConnection sqlCon;
        public void AbrirConexao()
        {
            string local = @"GUILHERME-NOTE\SQLEXPRESS";
            string nomeBD = @"BlackNight";
            string usuario = @"guilherme";
            string senha = @"123456";

            String stringConexao = "Data Source=" + local + ";";
            stringConexao += "Initial Catalog=" + nomeBD + ";";
            stringConexao += "UId=" + usuario + ";";
            stringConexao += "Password=" + senha + ";";

            sqlCon = new SqlConnection(stringConexao);
            sqlCon.Open();
        }

        public void FecharConexao()
        {
            sqlCon.Close();
            //sqlCon.Dispose();
        }
    }
}
