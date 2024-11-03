namespace WorkingAndProjecting.DbContext
{
    using Microsoft.EntityFrameworkCore;
    using WorkingAndProjecting.Model;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        // Define DbSet properties for your tables
        public DbSet<Worker> Workers { get; set; }
        //public DbSet<Customer> Customers { get; set; }
    }
}
