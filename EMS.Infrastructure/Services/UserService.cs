using System;
using System.Linq;

using EMS.Core.Application.Infrastructure;
using EMS.Core.Domain.Entities.ManagerAggregate;
using EMS.Infrastructure.Data;

namespace EMS.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly EMSDbContext _context;

        public UserService(EMSDbContext context) => _context = context;

        public Manager GetCurrentUser()
        {
            //var manager = _context.Managers
            //    .FirstOrDefault(m => m.ManagerGuid == Guid.Parse("783E92F6-85C0-48CD-9A09-C25BEAFC570C"));

            //return manager;
            return null;
        }
    }
}
