using Microsoft.EntityFrameworkCore;
using Model = Models.Entities;

namespace SetupProject.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Model.Employee> Employees { get; set; }
    }
}
