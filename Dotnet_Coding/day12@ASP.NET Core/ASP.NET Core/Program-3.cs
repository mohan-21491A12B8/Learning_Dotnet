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
            new Program().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source=QIS-MOHANSAI\\SQLEXPRESS;Initial Catalog=mohan;Integrated Security=True");
                //SqlCommand s1 = new SqlCommand("create table Mohansai(id int not null,name varchar(20),branch varchar(20))", conn);
                SqlCommand s1 = new SqlCommand("insert into Mohan(id,name,branch) values (1,'mohan','IT')", conn);
                conn.Open();
                s1.ExecuteNonQuery();
                Console.WriteLine("Data inserted successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
