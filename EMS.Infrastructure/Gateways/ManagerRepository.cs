using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using EMS.Core.Application.Gateways;
using EMS.Core.Domain.Entities.ManagerAggregate;
using EMS.Core.Domain.Exceptions;
using EMS.Infrastructure.Data;

using Microsoft.EntityFrameworkCore;

namespace EMS.Infrastructure.Gateways
{
    public class ManagerRepository : IManagerRepository
    {
        private readonly EMSDbContext _context;

        public ManagerRepository(EMSDbContext context) => _context = context;

        public Task AddAsync(Manager entity)
        {
            throw new NotImplementedException();
        }

        public Task<Manager> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Manager entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Manager entity)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> HireEmployeeAsync(
            Guid managerGuid,
            string firstName,
            string lastName,
            int age,
            string email,
            string department,
            decimal salary)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> FireEmployeeAsync(Guid managerGuid, Guid employeeGuid)
        {
            throw new NotImplementedException();
        }

        public async Task<Employee> PromoteEmployeeAsync(Guid managerGuid, Guid employeeGuid, decimal promotionAmount)
        {
            var employee = await _context.Employees.FirstOrDefaultAsync(e => e.EmployeeGuid == employeeGuid)
                            ?? throw new EmployeeNotFoundException();

            employee.Salary += promotionAmount;

            _context.Update(employee);
            await _context.SaveChangesAsync();

            return employee;
        }

        public Task<Employee> DemoteEmployeeAsync(Guid managerGuid, Guid employeeGuid, decimal demotionAmount)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Employee> GetAllEmployees(Guid managerGuid)
        {
            return _context.Employees.Where(e => e.ManagerGuid == managerGuid).ToList().AsReadOnly();
        }
    }
}
