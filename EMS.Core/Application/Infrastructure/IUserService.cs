using EMS.Core.Domain.Entities.ManagerAggregate;

namespace EMS.Core.Application.Infrastructure
{
    public interface IUserService
    {
        Manager GetCurrentUser();
    }
}
