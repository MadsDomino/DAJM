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
        DatabaseProcedures DatabaseProcedures = new DatabaseProcedures();
        private static string connectionstring = "server=ealb1.eal.local; Database= ejl04_db; User Id=ejl04_usr; Password=Baz1nga4;";

        static void Main(string[] args)
        {
            Program prog = new ConsoleApplication1.Program();
            prog.Run();
        }


        private void Run()
        {
            using (SqlConnection SqlCon = new SqlConnection(connectionstring))
            {
                SqlCon.Open();
                DatabaseProcedures.AddStudent(SqlCon, "Larsen", "Jonas", "DatamatikerA");
            }

        }
    }
}
