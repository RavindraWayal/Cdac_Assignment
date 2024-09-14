using ConsoleApp1.Models;
using ConsoleApp1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Controller
{

    public class EmployeeControllerDemo
    {
        IService service;
        public EmployeeControllerDemo(IService service)
        {
            this.service = service;
        }   
        
        public List<Employee> GetEmployee()
        {
            var list = service.GetAll();
            return list;
        }
        public void Addition(Department department)
        {
            service.Addto(department);
        }
        public void remove(int id)
        {
            service.Delete(id);
        }
    }
}
