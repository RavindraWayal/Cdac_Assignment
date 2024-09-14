using WebApplication1E_D.Models;

namespace WebApplication1E_D.Service
{
    public interface IEmployeeService
    {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetEmployees();
        Employee Add(Employee employee);
        Employee Update(Employee employee);
        Employee Delete(int id);
    }
}
