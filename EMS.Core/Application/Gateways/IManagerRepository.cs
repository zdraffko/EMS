using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using EMS.Core.Domain.Entities.ManagerAggregate;

namespace EMS.Core.Application.Gateways
{
    public interface IManagerRepository : IRepository<Manager>
    {
        Task<Employee> HireEmployeeAsync(
            Guid managerGuid,
            string firstName,
            string lastName,
            int age,
            string email,
            string department,
            decimal salary);

        Task<Employee> FireEmployeeAsync(Guid managerGuid, Guid employeeGuid);

        Task<Employee> PromoteEmployeeAsync(Guid managerGuid, Guid employeeGuid, decimal promotionAmount);

        Task<Employee> DemoteEmployeeAsync(Guid managerGuid, Guid employeeGuid, decimal demotionAmount);

        Task<IReadOnlyCollection<Employee>> GetAllEmployees(Guid managerGuid);
    }
}
