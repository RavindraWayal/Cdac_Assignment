using ConsoleApp4EmpEF.Model;
using ConsoleApp4EmpEF.Service;

namespace ConsoleApp4EmpEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Servicelayer servicelayer = new Servicelayer();
            servicelayer.Display();
            //servicelayer.Addition();
            //servicelayer.Delete(11);

            /*Department d = new Department
            {
                DeptName = "CEO"
            };
            servicelayer.Update(d);
            */
            //servicelayer.Search(3);
            //servicelayer.Searchbyname("Rahul");
            //servicelayer.Update1(1);
            servicelayer.Replace();
        }
    }
}

