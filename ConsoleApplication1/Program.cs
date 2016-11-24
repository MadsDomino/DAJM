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

        static void Main(string[] args)
        {
            Program Prog = new Program();
            Prog.Run();
        }


        private void Run()
        {
            SQLCon.LogIn();
            SQLCon.AddStudent("Efternavn", "Fornavn", "Klasse");
        }
    }
}
