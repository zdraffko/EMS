using EMS.Core.Domain.Entities.ManagerAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EMS.Infrastructure.Data.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> employeeBuilder)
        {
            employeeBuilder.Property(e => e.FirstName)
                .IsRequired();

            employeeBuilder.Property(e => e.LastName)
                .IsRequired();

            employeeBuilder.Property(e => e.Department)
                .IsRequired();

            employeeBuilder.Property(e => e.Salary)
                .HasColumnType("decimal(9,2)")
                .IsRequired();
        }
    }
}
