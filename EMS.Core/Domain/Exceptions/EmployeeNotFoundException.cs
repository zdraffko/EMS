using System;

namespace EMS.Core.Domain.Exceptions
{
    public class EmployeeNotFoundException : Exception
    {
        public EmployeeNotFoundException() : this("Employee not found!") { }

        public EmployeeNotFoundException(string message) : base(message) { }
    }
}
