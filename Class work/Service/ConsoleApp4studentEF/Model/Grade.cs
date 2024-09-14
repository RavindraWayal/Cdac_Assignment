using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4studentEF.Model
{
    public class Grade
    {
       public  int GradeiD { get; set; }
       public  string GradeName { get; set; }
       public  string Section { get; set; }
       public ICollection<Student> Students { get; set; }
    }
}
