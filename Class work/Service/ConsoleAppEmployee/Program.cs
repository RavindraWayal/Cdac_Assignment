using Microsoft.Extensions.Configuration;

namespace ConsoleAppEmployee
{
    internal class Program
    {
        private static IConfiguration iconnection;
        static void Main(string[] args)
        {
            GetAppSetting();
            Emp();
        }
        public static void GetAppSetting()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("jsconfig1.json", optional:false,reloadOnChange:true);
            iconnection = builder.Build();
        }
        public static void Emp()

        {
            //ployees emp1new Employees();
            EmpDAL e=new EmpDAL(iconnection);
           
            List<Employees>l=e.display();
            foreach(Employees emp in l)
            {
                Console.WriteLine("{0} {1} {2}",emp.id,emp.name,emp.salary);
            }
            Employees em = e.Search(2);
            Console.WriteLine("{0} {1} {2}",em.id,em.name,em.salary);

            Console.WriteLine("-----------------------------------");

            List<Employees> l2 = e.search1("Akshay");
            foreach(Employees emp2 in l2)
            {
                Console.WriteLine("{0} {1} {2}",emp2.id,emp2.name,emp2.salary);
            }
            int 
        }
    }
}
