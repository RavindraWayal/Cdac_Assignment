﻿using Microsoft.Extensions.Configuration;

namespace ConsoleApp3
{
    internal class Program
    {
        private static IConfiguration _iconfiguration;


        static void Main(string[] args)
        {

            GetAppSettings();
            printproduct();


        }
        static void GetAppSettings()
        {

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("jsconfig1.json", optional: false, reloadOnChange: true);
            _iconfiguration = builder.Build();
        }
        static void printproduct()
        {
            EmpDALDisconnect emp = new EmpDALDisconnect(_iconfiguration);
            emp.displayproduct();
        }
    }
}
