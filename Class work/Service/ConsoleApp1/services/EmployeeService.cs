using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.services
{
    internal class EmployeeService: Irpository
    {
        public static List<Employee>db=new List<Employee>() { new Employee() {Eid=1, Name="AKshay",Gender="Male" } };
       

        public void add(Employee e)
        {
            e.Eid = db.Max(e => e.Eid)+1;
            var m=db.Select(e => e.Eid).Max();
        }

        public List<Employee> display()
        {
            throw new NotImplementedException();
        }

        public Employee Getemp(int id)
        {
            Employee employee = db.Where((e) => e.Eid == id).Single();
            return employee;

        }

        public List<Employee> Getemp(string Name)
        {
            var m=db.Where()
        }

        public void remove(int id)
        {
            throw new NotImplementedException();
        }

        public void update(int id, string name)
        {
            throw new NotImplementedException();
        }
    }
}
