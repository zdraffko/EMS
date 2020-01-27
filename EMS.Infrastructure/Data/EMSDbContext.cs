using Microsoft.EntityFrameworkCore;

namespace EMS.Infrastructure.Data
{
    public class EMSDbContext : DbContext
    {
        public EMSDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
