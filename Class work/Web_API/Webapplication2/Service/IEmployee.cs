using Webapplication2.Models;

namespace Webapplication2.Service
{
    public interface IEmployee
    {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetAll();
        Employee Add(Employee employee);
        Employee Update(Employee employee);
        Employee Delete(int id);

    }
}
