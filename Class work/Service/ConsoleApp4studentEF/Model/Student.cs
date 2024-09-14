using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4studentEF.Model
{
    public class Student
    {
        public int Studentid { get; set; }
        public string StudentName { get; set; }

        [ForeignKey("Gradde")]
        public int Gradeid {  get; set; }
        public Grade Grade { get; set; }
        public string? Photo {  get; set; }

    }
}
