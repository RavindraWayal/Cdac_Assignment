using ConsoleApp4EmpEF.Model;
using ConsoleApp4EmpEF.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4EmpEF.Service
{
    internal class Servicelayer
    {
        protected readonly ApplicationContext context;
        public Servicelayer() 
        {
            context = new ApplicationContext();
        }

        public void Display()
        {
            var a=context.Employees.Include(d=>d.Department).ToList();
            foreach (var d in a)
            {
                Console.WriteLine($"{d.EId}\t\t{d.EmpName}\t\t{d.Salary}\t\t{d.Deptid}\t\t{d.Department.DeptName}");
            }
        }
        public void Addition()
        {
            Employee e = new Employee
            {
                EmpName = "Avdhut",
                Salary = 20000,
                Department = new Department
                {
                    DeptName = "Analyst"
                }
            };

            context.Add(e);
            context.SaveChanges();
            
        }

        public void Delete(int id)
        {
            var a=context.Employees.Single(a=>a.EId == id);
            context.Remove(a);
            context.SaveChanges();
        }
        public void Update(Department d)
        {
            context.Add(d);
            context.SaveChanges();
        }
        public void Search(int id)
        {
            var e = context.Employees.SingleOrDefault(a => a.EId == id);
            Console.WriteLine("{0} {1} {2} {3}  ",e.EId,e.EmpName,e.Salary,e.Department.DeptName);

        }
        public void Searchbyname(string name)
        {
            var e=context.Employees.FirstOrDefault(a=>a.EmpName == name);
            Console.WriteLine("{0} {1} {2} {3}",e.EId,e.EmpName,e.Salary,e.Department.DeptName);
        }
        public void Update1(int id)
        {
            ApplicationContext context = new ApplicationContext();
            Employee e = new Employee
            {
                EmpName = "Nidhi",
                Deptid = id,
                
            };
            context.Employees.Add(e);
            context.SaveChanges();
        }
        public void Replace()
        {
            Department d = new Department
            {
               
                DeptName = "Accontant",
                Employees = new List<Employee>
                {
                    new Employee {EmpName="Mahesh",Salary=40000},
                    new Employee {EmpName="Aditya",Salary=90000},
                    new Employee {EmpName="Balu",Salary=100000}
                }
            };
            context.Departments.AddRange(d);
            context.SaveChanges();
             
        }
        
    }
}
