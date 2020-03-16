using EMS.Core.Domain.Entities.ManagerAggregate;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EMS.Infrastructure.Data.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> employeeBuilder)
        {
            employeeBuilder.HasKey(e => e.Id);

            employeeBuilder.Property(e => e.EmployeeGuid)
                .IsRequired();

            employeeBuilder.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            employeeBuilder.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50);

            employeeBuilder.Property(e => e.Age)
                .IsRequired();

            employeeBuilder.Property(e => e.Department)
                .IsRequired()
                .HasConversion<string>();

            employeeBuilder.Property(e => e.Salary)
                .IsRequired()
                .HasColumnType("decimal(9,2)");

            employeeBuilder.Property(e => e.ManagerGuid)
                .IsRequired();
        }
    }
}
