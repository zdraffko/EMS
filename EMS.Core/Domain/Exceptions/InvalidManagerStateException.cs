using System;

namespace EMS.Core.Domain.Exceptions
{
    public class InvalidManagerStateException : Exception
    {
        public InvalidManagerStateException() : this("The Manager state is invalid!") { }

        public InvalidManagerStateException(string message) : base(message) { }
    }
}
