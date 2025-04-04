using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace LojaABC
{
    public class conexao
    {
        private static string stringconn = "Server=localhost;port=3306;Database=dbloja;Uid=lojaabc;Pwd=123456";
        private static MySqlConnection conn = null;

        public static MySqlConnection obterConexao()
        { 
          conn = new MySqlConnection(stringconn);
            try
            {
                conn.Open();
            }
            catch(MySqlException) 
            {
                conn = null;
            }
            return conn;
        }
        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();  
            }
        
        }
    
    }
}
