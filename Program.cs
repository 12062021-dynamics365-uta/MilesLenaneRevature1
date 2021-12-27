using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Project0
{
    class Program
    {
        static void Main(string[] args)

        {
           // bool menutest = true;
            Console.WriteLine();
            businesslogic program = new businesslogic();
           
           bool login = program.login_or_create_account();
            program.Menu(login);  
               
        }      

    }
}

