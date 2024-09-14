using WebTest.Models;

namespace WebTest.Service
{
    public interface IEmployee
    {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetAll();
    }
}
