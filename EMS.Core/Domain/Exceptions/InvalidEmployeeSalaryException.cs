using System;

namespace EMS.Core.Domain.Exceptions
{
    public class InvalidEmployeeSalaryException : Exception
    {
        public InvalidEmployeeSalaryException() : this("The employee salary is invalid!") { }

        public InvalidEmployeeSalaryException(string message) : base(message) { }
    }
}
