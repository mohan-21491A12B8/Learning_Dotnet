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
                
                SqlCommand s1 = new SqlCommand("insert into Mohan(id,name,branch) values (1,'Mohan Sai','IT')", conn);
                SqlCommand s2 = new SqlCommand("insert into Mohan(id,name,branch) values (2,'Uday Kiran Reddy','IT')", conn);
                SqlCommand s3 = new SqlCommand("insert into Mohan(id,name,branch) values (3,'Manideep Venkata Sai','IT')", conn);
                SqlCommand s4 = new SqlCommand("insert into Mohan(id,name,branch) values (4,'Venkata Lakshmaiah','IT')", conn);
                SqlCommand s5 = new SqlCommand("insert into Mohan(id,name,branch) values (5,'Venkatesh','IT')", conn);
                SqlCommand s6 = new SqlCommand("insert into Mohan(id,name,branch) values (6,'Pavan Raghav Kumar','IT')", conn);
                SqlCommand s7 = new SqlCommand("insert into Mohan(id,name,branch) values (7,'Chandra Mahesh','IT')", conn);
                SqlCommand s8 = new SqlCommand("insert into Mohan(id,name,branch) values (8,'Pavan Manikanta','IT')", conn);
                SqlCommand s9 = new SqlCommand("insert into Mohan(id,name,branch) values (9,'Mohith Bhargav','IT')", conn);
                SqlCommand s10 = new SqlCommand("insert into Mohan(id,name,branch) values (10,'Tharun','IT')", conn);

                conn.Open();
                s1.ExecuteNonQuery();
                s2.ExecuteNonQuery();
                s3.ExecuteNonQuery();
                s4.ExecuteNonQuery();
                s5.ExecuteNonQuery();
                s6.ExecuteNonQuery();
                s7.ExecuteNonQuery();
                s8.ExecuteNonQuery();
                s9.ExecuteNonQuery();
                s10.ExecuteNonQuery();
                
                Console.WriteLine("Data inserted successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
