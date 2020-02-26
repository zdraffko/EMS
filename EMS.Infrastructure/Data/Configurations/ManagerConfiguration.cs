using EMS.Core.Domain.Entities.ManagerAggregate;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EMS.Infrastructure.Data.Configurations
{
    public class ManagerConfiguration : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> managerBuilder)
        {
            managerBuilder.HasKey(m => m.Id);

            managerBuilder.Property(m => m.ManagerGuid)
                .IsRequired();

            managerBuilder.Property(m => m.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            managerBuilder.Property(m => m.LastName)
                .IsRequired()
                .HasMaxLength(50);

            managerBuilder.Property(m => m.Age)
                .IsRequired();

            managerBuilder.HasMany(m => m.Employees)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
