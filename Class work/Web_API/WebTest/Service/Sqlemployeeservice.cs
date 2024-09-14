using WebTest.Models;



namespace WebTest.Service
{
    public class Sqlemployeeservice:IEmployee
    {
        App1Context context;
        public Sqlemployeeservice(App1Context db)
        {
            context = db;
        }

        public IEnumerable<Employee> GetAll()
        {
            var b=context.Employees.ToList();
            return b;
        }

        public Employee GetEmployee(int id)
        {
           var a= context.Find<Employee>(id);
            context.SaveChanges();
            return a;
        }
    }
}
