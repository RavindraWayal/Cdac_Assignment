using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleAppEmployee
{
    internal class EmpDAL
    {
        private static  string connection;
        public EmpDAL(IConfiguration iconnecton)
        {
            connection = iconnecton.GetConnectionString("Default");
        }
        public static SqlConnection connetion()
        {
            return new SqlConnection(connection);
        }
        public List<Employees> display()
        {
            SqlConnection con=null;
            var list=new List<Employees>();
            try
            {
                con = EmpDAL.connetion();
                SqlCommand cmd = new SqlCommand("select * from Employees", con);
                
                //cmd.CommandType=CommandType.StoredProcedure;
                con.Open();
                Console.WriteLine("Connected");
                SqlDataReader rdr = cmd.ExecuteReader();
                if(rdr.HasRows)
                {
                    while(rdr.Read())
                    {
                        list.Add(new Employees
                        {
                            id = Convert.ToInt32(rdr[0]),
                            name = rdr[1].ToString(),
                            salary = Convert.ToInt32(rdr[2])

                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
            return list;
        }
        public Employees Search(int id)
        {
            SqlConnection conn = null;
            Employees list = null;
            try
            {
                conn = EmpDAL.connetion();
                SqlCommand cmd = new SqlCommand("select * from Employees where id=@Eid",conn);
                cmd.Parameters.AddWithValue("@Eid",id);
                conn.Open();
                SqlDataReader rdr=cmd.ExecuteReader();
                if(rdr.HasRows )
                {
                    while(rdr.Read())
                    {
                        list = new Employees();
                        list.id= Convert.ToInt32(rdr[0]);
                        list.name = (string)rdr[1];
                        list.salary = Convert.ToInt32(rdr[2]);
                        break;
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return list;
        }
        public List<Employees> search1(String s)
        {
            SqlConnection conn = null;
            var list = new List<Employees>();
            try
            {
                conn = EmpDAL.connetion();
                SqlCommand cmd = new SqlCommand("select * from Employees where name=@Name", conn);
                cmd.Parameters.AddWithValue("@Name",s);
                conn.Open();
                Console.WriteLine("Connected");
                SqlDataReader rdr=cmd.ExecuteReader();
                if(rdr.HasRows )
                {
                    while(rdr.Read())
                    {
                        list.Add(new Employees
                        {
                            id = Convert.ToInt32(rdr[0]),
                            name = (string)rdr[1],
                            salary = Convert.ToInt32(rdr[2]),
                        });
                    }
                }
            }
            catch (Exception e )
            {
                Console.WriteLine(e);
            }
            return list;
        }
        public int Deletedata(int id)
        {
            SqlConnection con = null;
            int rowaffected = 0;
            try
            {
                con = EmpDAL.connetion();
                SqlCommand cmd = new SqlCommand("delete from Employee where id=@Eid", con);
                con.Open();
                rowaffected = cmd.ExecuteNonQuery();
                return rowaffected;
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return rowaffected;
        }
    }
}
