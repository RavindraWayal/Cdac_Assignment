using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.services
{
    interface Irpository
    {
        void add(Employee e);
        void remove(int id);
        List<Employee> display();
        Employee Getemp(int id);
        List<Employee> Getemp(string Name);
        void update(int id, string name);


    }
}
