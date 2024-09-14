using Microsoft.Extensions.Configuration;

namespace ConsoleApp2ADO
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
            Employeelayer emp = new Employeelayer(_iconfiguration);
            
            Console.WriteLine("---------------------------");
            /*emp.Insert();
            emp.Display();
            emp.update();
            emp.Delete();
            emp.Display();
            emp.Display1();
            */
            emp.displayproduct("l");
            
        }
    }
}
