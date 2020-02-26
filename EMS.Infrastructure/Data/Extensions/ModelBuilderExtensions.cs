﻿using System;
using EMS.Core.Domain.Entities.ManagerAggregate;

using Microsoft.EntityFrameworkCore;

namespace EMS.Infrastructure.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void SeedDatabase(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manager>()
                .HasData(
                    new
                    {
                        Id = 1,
                        ManagerGuid = Guid.NewGuid(),
                        FirstName = "Manager",
                        LastName = "One",
                        Age = 24
                    }
                    );

            modelBuilder.Entity<Employee>()
                .HasData(
                    new
                    {
                        Id = 1,
                        ManagerId = 1,
                        EmployeeGuid = Guid.NewGuid(),
                        FirstName = "Employee",
                        LastName = "One",
                        Age = 20,
                        Department = Department.Development,
                        Salary = 5000m
                    },
                    new
                    {
                        Id = 2,
                        ManagerId = 1,
                        EmployeeGuid = Guid.NewGuid(),
                        FirstName = "Employee",
                        LastName = "Two",
                        Age = 22,
                        Department = Department.HR,
                        Salary = 2000m
                    },
                    new
                    {
                        Id = 3,
                        ManagerId = 1,
                        EmployeeGuid = Guid.NewGuid(),
                        FirstName = "Employee",
                        LastName = "Three",
                        Age = 27,
                        Department = Department.Security,
                        Salary = 7000m
                    }
                    );
        }
    }
}
