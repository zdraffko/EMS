using System;
using System.Security.Claims;
using System.Threading.Tasks;

using EMS.Core.Application.Infrastructure;
using EMS.Core.Domain.Entities.ManagerAggregate;
using EMS.Infrastructure.Identity;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EMS.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserService(UserManager<ApplicationUser> userManager) => _userManager = userManager;

        public async Task<Guid> GetUserGuidAsync(ClaimsPrincipal applicationUser)
        {
            var userId = _userManager.GetUserId(applicationUser);
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == userId);

            return user.ManagerGuid;
        }

        public async Task<bool> CreateUserAsync(Manager manager, string password)
        {
            var user = new ApplicationUser
            {
                FirstName = manager.FirstName,
                LastName = manager.LastName,
                Age = manager.Age,
                Email = manager.Email
            };

            var identityResult = await _userManager.CreateAsync(user, password);

            return identityResult.Succeeded;
        }
    }
}
