using System;
using System.Linq;

using EMS.Core.Application.Infrastructure;
using EMS.Core.Domain.Entities.ManagerAggregate;
using EMS.Core.Domain.Exceptions;
using EMS.Infrastructure.Data;

namespace EMS.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly EMSDbContext _context;

        public UserService(EMSDbContext context) => _context = context;

        public Manager GetCurrentUser()
        {
            var manager = _context.Managers
                              .FirstOrDefault(
                                  m => m.ManagerGuid == Guid.Parse("A22FDBCD-B327-4412-BB02-291ACA709752"))
                              ?? throw new ManagerNotFoundException();

            return manager;
        }
    }
}
