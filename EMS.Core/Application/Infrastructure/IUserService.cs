using System;
using System.Security.Claims;
using System.Threading.Tasks;
using EMS.Core.Domain.Entities.ManagerAggregate;

namespace EMS.Core.Application.Infrastructure
{
    public interface IUserService
    {
        Task<Guid> GetUserGuidAsync(ClaimsPrincipal applicationUser);

        Task<bool> CreateUserAsync(Manager user, string password);
    }
}
