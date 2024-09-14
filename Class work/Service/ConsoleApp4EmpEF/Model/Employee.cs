using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4EmpEF.Model
{
    public class Employee
    {
        [Key]
        public int EId { get; set; }
        public string EmpName { get; set; }
        public float Salary {  get; set; }
        public Department Department { get; set; }

        [ForeignKey("Department")]
        public int Deptid {  get; set; }

        
    }
}
