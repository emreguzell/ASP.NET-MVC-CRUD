using Microsoft.EntityFrameworkCore;
using MVCCRUD.Models.Domain;

namespace MVCCRUD.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
