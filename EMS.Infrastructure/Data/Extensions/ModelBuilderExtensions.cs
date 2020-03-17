using System;

using EMS.Core.Domain.Entities.ManagerAggregate;
using EMS.Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;

namespace EMS.Infrastructure.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void SeedDatabase(this ModelBuilder modelBuilder)
        {
            var manager = new ApplicationUser
            {
                ManagerGuid = Guid.NewGuid(),
                FirstName = "Manager",
                LastName = "One",
                Age = 24
            };

            modelBuilder.Entity<ApplicationUser>()
                .HasData(manager);

            modelBuilder.Entity<Employee>()
                .HasData(
                    new
                    {
                        Id = 1,
                        ApplicationUserId = manager.Id,
                        EmployeeGuid = Guid.NewGuid(),
                        FirstName = "Employee",
                        LastName = "One",
                        Age = 20,
                        Department = Department.Development,
                        Salary = 5000m,
                        manager.ManagerGuid
                    },
                    new
                    {
                        Id = 2,
                        ApplicationUserId = manager.Id,
                        EmployeeGuid = Guid.NewGuid(),
                        FirstName = "Employee",
                        LastName = "Two",
                        Age = 22,
                        Department = Department.HR,
                        Salary = 2000m,
                        manager.ManagerGuid
                    },
                    new
                    {
                        Id = 3,
                        ApplicationUserId = manager.Id,
                        EmployeeGuid = Guid.NewGuid(),
                        FirstName = "Employee",
                        LastName = "Three",
                        Age = 27,
                        Department = Department.Security,
                        Salary = 7000m,
                        manager.ManagerGuid
                    }
                    );
        }
    }
}
