using EmployeeDemo.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDemo.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
