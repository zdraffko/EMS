using System;
using System.Collections.Generic;

using EMS.Core.Domain.Exceptions;
using EMS.Core.Domain.Interfaces;

namespace EMS.Core.Domain.Entities.ManagerAggregate
{
    public class Manager : BaseEntity, IAggregateRoot
    {
        public Guid ManagerGuid { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public int Age { get; }

        private readonly List<Employee> _employees;
        public IReadOnlyCollection<Employee> Employees => _employees;

        private Manager() { }

        public Manager(string firstName, string lastName, int age)
        {
            if (!ValidateState(firstName, lastName, age))
            {
                throw new InvalidManagerStateException("Manager constructor is invalid");
            }

            ManagerGuid = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            _employees = new List<Employee>();
        }

        public void HireEmployee(string firstName, string lastName, int age, string department, decimal salary)
        {
            _employees.Add(new Employee(firstName, lastName, age, department, salary, ManagerGuid));
        }

        public void FireEmployee(Guid employeeGuid)
        {
            if (employeeGuid == null)
            {
                throw new ArgumentNullException(nameof(employeeGuid));
            }

            var employee = _employees.Find(e => e.EmployeeGuid == employeeGuid);

            if (employee == null)
            {
                throw new EmployeeNotFoundException();
            }

            _employees.Remove(employee);
        }

        public void PromoteEmployee(Guid employeeGuid, decimal promotionAmount)
        {
            if (employeeGuid == null)
            {
                throw new ArgumentNullException(nameof(employeeGuid));
            }

            if (promotionAmount <= 0)
            {
                throw new ArgumentException("The promotion amount must be greater than 0");
            }

            var employee = _employees.Find(e => e.EmployeeGuid == employeeGuid);

            if (employee == null)
            {
                throw new EmployeeNotFoundException();
            }

            employee.Salary += promotionAmount;
        }

        public void DemoteEmployee(Guid employeeGuid, decimal demotionAmount)
        {
            if (employeeGuid == null)
            {
                throw new ArgumentNullException(nameof(employeeGuid));
            }

            if (demotionAmount <= 0)
            {
                throw new ArgumentException("The demotion amount must be greater than 0");
            }

            var employee = _employees.Find(e => e.EmployeeGuid == employeeGuid);

            if (employee == null)
            {
                throw new EmployeeNotFoundException();
            }

            if (employee.Salary - demotionAmount <= 0)
            {
                throw new InvalidEmployeeSalaryException("The new salary cannot be less than or equal to 0");
            }

            employee.Salary -= demotionAmount;
        }

        private static bool ValidateState(string firstName, string lastName, int age)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                return false;
            }

            if (age < 18)
            {
                return false;
            }

            return true;
        }
    }
}
