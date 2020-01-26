using System;

namespace EMS.Core.Entities.ManagerAggregate
{
    public class Employee
    {
        public Guid EmployeeId { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public int Age { get; }

        public string Email { get; }

        public string Department { get; }

        public decimal Salary { get; set; }

        public Guid ManagerId { get; }

        public Employee(string firstName, string lastName, int age, string email, string department, decimal salary, Guid managerId)
        {
            if (!ValidateState(firstName, lastName, age, email, department, salary))
            {
                throw new Exception();
            }

            EmployeeId = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Email = email;
            Department = department;
            Salary = salary;
            ManagerId = managerId;
        }

        private bool ValidateState(string firstName, string lastName, int age, string email, string department, decimal salary)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                return false;
            }

            if (age < 18)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(email))
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
