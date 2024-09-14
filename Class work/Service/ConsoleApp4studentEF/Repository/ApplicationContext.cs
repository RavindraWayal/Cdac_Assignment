using ConsoleApp4studentEF.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4studentEF.Repository
{
    public class ApplicationContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=Student;Integrated Security=True;");
        }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Stations { get; set; }
    }
}
