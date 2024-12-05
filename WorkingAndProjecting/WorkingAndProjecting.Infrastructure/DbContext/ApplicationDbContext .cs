namespace WorkingAndProjecting.DbContext
{
    using Microsoft.EntityFrameworkCore;
    using WorkingAndProjecting.Domain.Entities;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        // Define DbSet properties for your tables
        public DbSet<User> Users { get; set; }
        public DbSet<WorkerProject> WorkerProjects { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
