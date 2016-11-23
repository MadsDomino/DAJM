using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApplication1
{
    public class DatabaseProcedures
    {
       public void AddStudent(SqlConnection SqlCon, string Efternavn, string Fornavn, string Klasse)
        {
            SqlCommand cmd1 = new SqlCommand("AddStudent", SqlCon);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.Add(new SqlParameter("ElevEfternavn", Efternavn));
            cmd1.Parameters.Add(new SqlParameter("ElevFornavn", Fornavn));
            cmd1.Parameters.Add(new SqlParameter("ElevKlasse", Klasse));
            cmd1.ExecuteNonQuery();
        }

    }
}
