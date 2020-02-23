using EMS.Core.Domain.Entities.ManagerAggregate;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EMS.Infrastructure.Data.Configurations
{
    public class ManagerConfiguration : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> managerBuilder)
        {
            managerBuilder.HasMany(m => m.Employees)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);

            managerBuilder.Property(m => m.FirstName)
                .IsRequired();

            managerBuilder.Property(m => m.LastName)
                .IsRequired();
        }
    }
}
