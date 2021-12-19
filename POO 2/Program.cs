using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace POO_2
{
    class Program
    {

        static void Main(string[] args)
        {
            //MENU DE OPÇÕES
            Console.WriteLine("Digite 1 para adicionar registro");
            Console.WriteLine("Digite 2 para exibir todos registro");
            Console.WriteLine("Digite 3 deletar registro");
            Console.WriteLine("Digite 4 atualizar registro");
            Console.Write("Digite uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            //ADICIONAR
            Adicionar _add = new Adicionar();
            _add.add();

           




            

        }
    }
}
