using Webapplication2.Models;

namespace Webapplication2.Service
{
    public class SqlEmpService:IEmployee
    {
      private readonly AppdbContext context;
        public SqlEmpService(AppdbContext context)
        {
            this.context = context;
        }

        public Employee Add(Employee employee)
        {
            var b=context.Employees.Add(employee);
            context.SaveChanges();
            return employee;
        }

        public Employee Delete(int id)
        {
            var b=context.Employees.First(x => x.Id == id);
            if(b != null)
            {
                context.Remove(b);
                context.SaveChanges();
            }
            return b;
        }

        public IEnumerable<Employee> GetAll()
        {
            var b = context.Employees.ToList();
            return b;
        }

        public Employee GetEmployee(int id)
        {
            var a = context.Find<Employee>(id);
            context.SaveChanges();
            return a;
        }

        public Employee Update(Employee employee)
        {
            var b = context.Update(employee);
            context.SaveChanges();
            return employee ;
        }
    }
}
