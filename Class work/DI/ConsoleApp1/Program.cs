using ConsoleApp1.Controller;
using ConsoleApp1.Models;
using ConsoleApp1.Repository;
using ConsoleApp1.Service;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var service=new ServiceCollection();
            service.AddTransient<IService,Servicelayer>();
            service.AddTransient<EmployeeControllerDemo>();
            service.AddTransient<SampledbContext>();

            var provider=service.BuildServiceProvider();
            var obj=provider.GetService<EmployeeControllerDemo>();

            var a = obj.GetEmployee();
            foreach(var e in a)
            {
                Console.WriteLine("{0} {1} {2} {3}",e.EmpId,e.EmpName,e.Department.DeptName,e.Salary);
            }
            Department d = new Department
            {
                DeptName = "Developer",
                Employees = new List<Employee>
            {
                new Employee {EmpName="Avdhut",Salary=40000},
                new Employee {EmpName="Mahesh",Salary=5000}
            }
            };
            obj.Addition(d);
            obj.remove(3);
        }
    }
}
