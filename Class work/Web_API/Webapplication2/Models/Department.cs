namespace Webapplication2.Models
{
    public class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
