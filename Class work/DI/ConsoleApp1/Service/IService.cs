using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Service
{
   public interface IService
    {
        public List<Employee> GetAll();
        public void Addto(Department department);

        public void Delete(int id);
        
    }
}
