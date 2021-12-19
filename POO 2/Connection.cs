using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace POO_2
{
    public class Connection
    {
        public string cs = "DATA SOURCE=RENAN-PC; INITIAL CATALOG=FTI; Trusted_Connection=True";
        public void Conectar()
        {
            try
            {
                SqlConnection conn;
                conn = new SqlConnection(cs);
                conn.Open();
                Console.WriteLine("Conexão realizada com sucesso!");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
               
        }
    }
}
