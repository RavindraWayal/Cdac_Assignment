using System.ComponentModel.DataAnnotations;

namespace WebApplication1E_D.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public ICollection<Employee> Employees { get; set; }    
    }
}
