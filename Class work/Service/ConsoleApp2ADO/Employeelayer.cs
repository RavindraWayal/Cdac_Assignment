using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2ADO
{
    internal class Employeelayer
    {
        private static string connection;
        private static string connection1;

        public Employeelayer(IConfiguration iconfiguration)
        {
            if (iconfiguration != null)
            {
                connection = iconfiguration.GetConnectionString("Default");
                connection1 = iconfiguration.GetConnectionString("Default1");
            }

        }
        public static SqlConnection Connections()
        {
            
             return new SqlConnection(connection);
            
        }
        public static SqlConnection Connections1()
        {

            return new SqlConnection(connection1);

        }
        public void Display()
        {
            SqlConnection conn = null;
            try
            {
                 conn=Employeelayer.Connections();
                    
                    SqlCommand cmd = new SqlCommand("select * from Employee", conn);
                conn.Open();
                    
                    Console.WriteLine("Connected");
                    SqlDataReader reader = cmd.ExecuteReader();


                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("{0} {1} {2} {3}",reader["Id"],reader["name"], reader["age"],reader["salary"]);
                        }
                    }
                }
 
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public void Insert() 
        {
            SqlConnection conn=null;
            try
            {
                 conn = Employeelayer.Connections();
                SqlCommand cmd = new SqlCommand("insert into Employee values('xys',20,30000)",conn);
                conn.Open();
                int rowaffected = cmd.ExecuteNonQuery();
                Console.WriteLine("insered " + rowaffected + " affected");
            }
            catch (Exception e) 
            {
                Console.WriteLine (e);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                
            }

        }
        public void update()
        {
            SqlConnection conn=null;
            try
            {
                conn = Employeelayer.Connections();
                SqlCommand cmd = new SqlCommand("update Employee set age=23 where id=2",conn);
                conn.Open();
                int rowaffected = cmd.ExecuteNonQuery();
                Console.WriteLine("update " + rowaffected);
            }
            catch (Exception e)
            {
                Console.WriteLine (e);  
            }
            finally
            {
                if(conn != null)
                { conn.Close(); }
            }
        }
        public void Delete()
        {
            SqlConnection conn=null;
            try
            {
                conn = Employeelayer.Connections();
                SqlCommand cmd = new SqlCommand("delete from Employee where Id=1002",conn);
                conn.Open();
                int rowaffected = cmd.ExecuteNonQuery();
                Console.WriteLine("delete" + rowaffected);
            }
            catch(Exception e)
            {
                Console.WriteLine (e);  
            }
            finally
            {
                if( conn != null )
                { conn.Close(); }
            }
        }
        public void Display1()
        {
            SqlConnection conn = null;
            try
            {
                conn = Employeelayer.Connections1();

                SqlCommand cmd = new SqlCommand("select * from Product", conn);
                conn.Open();

                Console.WriteLine("Connected");
                SqlDataReader reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0} {1} {2} {3}", reader["id"], reader["name"], reader["price"], reader["Qyt"]);
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public void displayproduct(string s)
        {
            SqlConnection con = null;
            try
            {
                con = Employeelayer.Connections1();
                SqlCommand cmd = new SqlCommand("SP_PRODUCT",con);
                
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductName", s + '%');
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0} {1} {2} {3}", reader["id"], reader["name"], reader["price"], reader["Qyt"]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                if (con != null)
                con.Close();
            }
        }
    }
}
