using System;
using System.Threading.Tasks;
using EMS.Core.Domain.Entities.ManagerAggregate;

namespace EMS.Core.Domain.Interfaces
{
    public interface IManagerRepository : IRepository<Manager>
    {
        Task HireEmployeeAsync(Guid managerId, string firstName, string lastName, int age, string email, string department, decimal salary);

        Task FireEmployeeAsync(Guid managerId, Guid employeeId);

        Task PromoteEmployeeAsync(Guid managerId, Guid employeeId, decimal promotionAmount);

        Task DemoteEmployeeAsync(Guid managerId, Guid employeeId, decimal demotionAmount);
    }
}
