using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class EmpDALDisconnect
    {
        private string _connectionString;
        SqlDataAdapter dataAdapter;
        DataSet dataset;
        SqlConnection connection;
        public EmpDALDisconnect(IConfiguration iconfiguration)
        {
            _connectionString = iconfiguration.GetConnectionString("Default");
        }
        // Create an instance of DataSet, which is an in-memory datastore for storing tables
        public void displayproduct()
        {
            connection = new SqlConnection(_connectionString);

            dataAdapter = new SqlDataAdapter("select * from Employee", connection);
            dataset = new DataSet();


            dataAdapter.FillSchema(dataset, SchemaType.Source, "Employee");
            dataAdapter.Fill(dataset, "Employee");
            DataTable dt = dataset.Tables["Employee"];
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                    Console.Write(row[col] + " ");
                Console.WriteLine("----------------------------------");
            }

        }
        public void Add()
        {
            DataRow drCurrent = dataset.Tables["Employee"].NewRow();
            drCurrent["Id"] = 6;
            drCurrent["name"] = "Shahrukh";
            drCurrent["age"] = 23;
            drCurrent["salary"] = 100000;
            dataset.Tables["Employee"].Rows.Add(drCurrent);
        }
    }
}
