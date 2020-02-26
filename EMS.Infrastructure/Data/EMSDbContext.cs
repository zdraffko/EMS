using EMS.Core.Domain.Entities.ManagerAggregate;
using EMS.Infrastructure.Data.Extensions;

using Microsoft.EntityFrameworkCore;

namespace EMS.Infrastructure.Data
{
    public class EMSDbContext : DbContext
    {
        public EMSDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Manager> Managers { get; set; }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            modelBuilder.SeedDatabase();
        }
    }
}
