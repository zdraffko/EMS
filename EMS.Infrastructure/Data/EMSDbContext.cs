using EMS.Core.Domain.Entities.ManagerAggregate;
using EMS.Infrastructure.Data.Extensions;
using EMS.Infrastructure.Identity;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EMS.Infrastructure.Data
{
    public class EMSDbContext : IdentityDbContext<ApplicationUser>
    {
        public EMSDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            modelBuilder.SeedDatabase();
        }
    }
}
