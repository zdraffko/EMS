using System;

namespace EMS.Core.Domain.Exceptions
{
    public class InvalidEmployeeStateException : Exception
    {
        public InvalidEmployeeStateException() : this("The Employee state is invalid!") { }

        public InvalidEmployeeStateException(string message) : base(message) { }
    }
}
