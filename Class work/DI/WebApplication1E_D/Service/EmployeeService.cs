using Microsoft.EntityFrameworkCore;
using WebApplication1E_D.Models;
using WebApplication1E_D.Repository;

namespace WebApplication1E_D.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly SampleDbContext db;
        public EmployeeService(SampleDbContext db)
        {
            this.db = db;
        }
        public Employee Add(Employee employee)
        {
            var a=db.Employees.Include(e=>e.Departmnet);
            db.Add(a);
            db.SaveChanges();
            return employee;
        }

        public Employee Delete(int id)
        {
            var a=db.Find<Employee>(id);
            db.SaveChanges();
            return a;
        }

        public Employee GetEmployee(int id)
        {
            var a=db.Employees.Include(e=>e.Departmnet).SingleOrDefault(e=>e.EmpId==id);
            return a;

        }

        public IEnumerable<Employee> GetEmployees()
        {
            var a=db.Employees.ToList();
            return a;
        }

        public Employee Update(Employee employee)
        {
            var a=db.Employees.Add(employee);
            db.Update(a);
            db.SaveChanges();
            return employee;
        }
    }
}
