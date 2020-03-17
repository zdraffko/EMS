using EMS.Infrastructure.Identity;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EMS.Infrastructure.Data.Configurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> userBuilder)
        {
            userBuilder.ToTable(name: "Managers");

            userBuilder.Property(u => u.ManagerGuid)
                .IsRequired();

            userBuilder.Property(u => u.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            userBuilder.Property(u => u.LastName)
                .IsRequired()
                .HasMaxLength(50);

            userBuilder.Property(u => u.Age)
                .IsRequired();
        }
    }
}
