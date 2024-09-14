using Microsoft.EntityFrameworkCore;

namespace WebTest.Models
{
    public class App1Context:DbContext
    {
        public App1Context(DbContextOptions<App1Context> options):base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
