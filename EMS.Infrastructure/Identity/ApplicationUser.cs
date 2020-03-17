using System;
using System.Collections.Generic;

using EMS.Core.Domain.Entities.ManagerAggregate;

using Microsoft.AspNetCore.Identity;

namespace EMS.Infrastructure.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public Guid ManagerGuid { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
