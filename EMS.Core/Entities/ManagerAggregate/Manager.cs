using EMS.Core.Interfaces;
using System;
using System.Collections.Generic;

namespace EMS.Core.Entities.ManagerAggregate
{
    public class Manager : IAggregateRoot
    {
        public Guid ManagerId { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public int Age { get; }

        public string Email { get; }

        private readonly List<Employee> _employees;
        public IReadOnlyCollection<Employee> Employees => _employees;

        public Manager(string firstName, string lastName, int age, string email)
        {
            if (!ValidateState(firstName, lastName, age, email))
            {
                throw new Exception("Constructor is invalid");
            }

            ManagerId = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Email = email;
            _employees = new List<Employee>();
        }

        public void HireEmployee(string firstName, string lastName, int age, string email, string department, decimal salary)
        {
            _employees.Add(new Employee(firstName, lastName, age, email, department, salary, ManagerId));
        }

        public void FireEmployee(Guid employeeId)
        {
            if (employeeId == null)
            {
                throw new ArgumentNullException(nameof(employeeId));
            }

            var employee = _employees.Find(e => e.EmployeeId == employeeId);

            if (employee == null)
            {
                throw new Exception("Employee not found");
            }

            _employees.Remove(employee);
        }

        public void PromoteEmployee(Guid employeeId, decimal promotionAmount)
        {
            if (employeeId == null)
            {
                throw new ArgumentNullException(nameof(employeeId));
            }

            if (promotionAmount <= 0)
            {
                throw new ArgumentException("The promotion amount must be greater than 0");
            }

            var employee = _employees.Find(e => e.EmployeeId == employeeId);

            if (employee == null)
            {
                throw new Exception("Employee not found");
            }

            employee.Salary += promotionAmount;
        }

        public void DemoteEmployee(Guid employeeId, decimal demotionAmount)
        {
            if (employeeId == null)
            {
                throw new ArgumentNullException(nameof(employeeId));
            }

            if (demotionAmount <= 0)
            {
                throw new ArgumentException("The demotion amount must be greater than 0");
            }

            var employee = _employees.Find(e => e.EmployeeId == employeeId);

            if (employee == null)
            {
                throw new Exception("Employee not found");
            }

            if (employee.Salary - demotionAmount <= 0)
            {
                throw new Exception("The new salary cannot be less than or equal to 0");
            }

            employee.Salary -= demotionAmount;
        }

        private bool ValidateState(string firstName, string lastName, int age, string email)
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

            return true;
        }
    }
}
