using System;
using EMS.Core.Domain.Exceptions;

namespace EMS.Core.Domain.Entities.ManagerAggregate
{
    public class Employee : BaseEntity
    {
        public Guid EmployeeGuid { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public int Age { get; }

        public string Department { get; }

        public decimal Salary { get; set; }

        public Guid ManagerGuid { get; }

        private Employee() { }

        public Employee(string firstName, string lastName, int age, string department, decimal salary, Guid managerGuid)
        {
            if (!ValidateState(firstName, lastName, age, department, salary))
            {
                throw new InvalidEmployeeStateException("Employee constructor is invalid");
            }

            EmployeeGuid = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Department = department;
            Salary = salary;
            ManagerGuid = managerGuid;
        }

        private static bool ValidateState(string firstName, string lastName, int age, string department, decimal salary)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                return false;
            }

            if (age < 18)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(department))
            {
                return false;
            }

            if (salary <= 0)
            {
                return false;
            }

            return true;
        }
    }
}
