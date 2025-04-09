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
            new Program().DeleteTable();
        }
        public void DeleteTable() {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source=QIS-MOHANSAI\\SQLEXPRESS;Initial Catalog=mohan;Integrated Security=True");
                SqlCommand s1 = new SqlCommand("drop table if exists Mohan", conn);
               
                conn.Open();
                
                s1.ExecuteNonQuery();
                Console.WriteLine("Table deleted success");
                        }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
