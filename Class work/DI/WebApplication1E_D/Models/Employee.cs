using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1E_D.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }  
        public string EmpName { get; set; }
        public double Salary { get; set; }
        public Department Departmnet { get; set; }
        [ForeignKey("Department")]
        public int DeptId {  get; set; }
    }
}
