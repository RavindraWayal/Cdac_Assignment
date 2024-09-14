using Microsoft.EntityFrameworkCore;
using WebApplication1E_D.Models;

namespace WebApplication1E_D.Repository
{
    public class SampleDbContext:DbContext
    {
        public SampleDbContext(DbContextOptions<SampleDbContext> options) : base(options) { }
        public DbSet<Employee>Employees { get; set; }
        public DbSet<Department>Departments { get; set; }

    }
}
