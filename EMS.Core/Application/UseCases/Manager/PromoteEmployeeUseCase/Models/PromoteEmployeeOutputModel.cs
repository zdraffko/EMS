﻿using EMS.Core.Domain.Entities.ManagerAggregate;

namespace EMS.Core.Application.UseCases.Manager.PromoteEmployeeUseCase.Models
{
    public class PromoteEmployeeOutputModel
    {
        public PromoteEmployeeOutputModel(
            string firstName,
            string lastName,
            Department department,
            decimal salary)
            => (FirstName, LastName, Department, Salary) = (firstName, lastName, department, salary);

        public string FirstName { get; }

        public string LastName { get; }

        public Department Department { get; }

        public decimal Salary { get; }
    }
}
