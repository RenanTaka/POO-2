using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace POO_2
{
    class Adicionar
    {
        public void add()
        {
            string cs = ("DATA SOURCE=RENAN-PC; INITIAL CATALOG=FTI; Trusted_Connection=True");
            try
            {
                SqlConnection conn;
                conn = new SqlConnection(cs);
                conn.Open();
                Console.WriteLine("Conexão realizada com sucesso!");

                Console.Write("Digite o ID da banda: ");
                int ID = int.Parse(Console.ReadLine());
                Console.Write("Digite a descrição da banda: ");
                string descricao = Console.ReadLine();

                string insertQuery = "INSERT INTO Bandas VALUES (" + ID + ",'" + descricao + "')";
                SqlCommand command = new SqlCommand(insertQuery, conn);
                command.ExecuteNonQuery();
                conn.Close();
                Console.WriteLine("Registro adicionado com sucesso!!!");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

            }
            
        }
        
    }
}
