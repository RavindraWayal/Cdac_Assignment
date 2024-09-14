using ConsoleApp1.Models;
using ConsoleApp1.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Service
{
    internal class Servicelayer : IService
    {
       private readonly SampledbContext context;
        public Servicelayer(SampledbContext context)
        {
            this.context = context;
        }

        public List<Employee> GetAll()
        {
            var a=context.Employees.Include(e=>e.Department).ToList();
            return a;
        }
        public void Addto(Department department)
        {
            context.Departments.Add(department);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var a = context.Employees.First(e=>e.EmpId==id);
            context.Remove(a);
            context.SaveChanges();
        }
    }
}
