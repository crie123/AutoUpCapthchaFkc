using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class ConsoleComms
    {
        public void Data()
        {
            Console.WriteLine("Email");
            VariablesConsole.mail = Console.ReadLine();
            Console.WriteLine("Pass");
            string? password = Console.ReadLine();
            do
            {
                Console.WriteLine("no wrong");
                password = Console.ReadLine();
            }
            while (password != VariablesConsole.pass);
            {
                Console.WriteLine("check");
            }
        }
        public class VariablesConsole
        {
            public static string mail = "check";
            public static string pass = "123";
        }
    }
}
