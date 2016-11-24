using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApplication1
{
    class Program
    {
        SQLConnection SQLCon = new SQLConnection();
        ConsoleCommands CCommand = new ConsoleCommands();

        static void Main(string[] args)
        {
            Program Prog = new Program();
            Prog.Run();
        }


        private void Run()
        {
            bool running = true;
            while(running)
            {
                string userInput = Console.ReadLine();
                CCommand.InputReader(userInput, SQLCon);
                if (userInput == "close")
                {
                    running = false;
                }
            }
            //SQLCon.LogIn();
            //SQLCon.AddStudent("Efternavn", "Fornavn", "Klasse");
            //Console.WriteLine("Complete!");
            //Console.ReadLine();
        }
    }
}
