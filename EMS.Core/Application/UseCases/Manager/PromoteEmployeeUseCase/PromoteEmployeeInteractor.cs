using System;
using System.Threading.Tasks;

using EMS.Core.Application.Gateways;
using EMS.Core.Application.Infrastructure;
using EMS.Core.Application.Ports;
using EMS.Core.Application.UseCases.Manager.PromoteEmployeeUseCase.Models;

namespace EMS.Core.Application.UseCases.Manager.PromoteEmployeeUseCase
{
    public class PromoteEmployeeInteractor : IPromoteEmployeeInputPort
    {
        private readonly IManagerRepository _managerRepository;
        private readonly IUserService _userService;

        public PromoteEmployeeInteractor(
            IManagerRepository managerRepository,
            IUserService userService)
        {
            _managerRepository = managerRepository ?? throw new ArgumentNullException(nameof(managerRepository));
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        public async Task Handle(PromoteEmployeeInputModel input, IOutputPort<PromoteEmployeeOutputModel> output)
        {
            var managerGuid = await _userService.GetUserGuidAsync(input.User);

            if (managerGuid == Guid.Empty)
            {
                output.Fail();
                return;
            }

            var employeeGuid = input.EmployeeGuid;
            var promotionAmount = input.PromotionAmount;

            var employee = await _managerRepository.PromoteEmployeeAsync(managerGuid, employeeGuid, promotionAmount);

            output.Success(new PromoteEmployeeOutputModel(
                employee.FirstName,
                employee.LastName,
                employee.Department,
                employee.Salary));
        }
    }
}
