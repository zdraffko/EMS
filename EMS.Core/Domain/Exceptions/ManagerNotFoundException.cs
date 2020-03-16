using System;

namespace EMS.Core.Domain.Exceptions
{
    public class ManagerNotFoundException : Exception
    {
        public ManagerNotFoundException() : this("Manager not found!") { }

        public ManagerNotFoundException(string message) : base(message) { }
    }
}
