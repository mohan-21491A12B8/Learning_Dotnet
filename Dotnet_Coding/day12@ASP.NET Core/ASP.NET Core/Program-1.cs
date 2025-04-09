using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("QIS-MOHANSAI\\SQLEXPRESS");
            con.open();
            Console.WriteLine("connection established sucessfully");

        }
    }
}