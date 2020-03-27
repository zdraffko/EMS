using System;
using System.Security.Claims;

namespace EMS.Core.Application.UseCases.Manager.PromoteEmployeeUseCase.Models
{
    public class PromoteEmployeeInputModel
    {
        public PromoteEmployeeInputModel(ClaimsPrincipal user, Guid employeeGuid, decimal promotionAmount)
            => (User, EmployeeGuid, PromotionAmount) = (user, employeeGuid, promotionAmount);

        public ClaimsPrincipal User { get; }

        public Guid EmployeeGuid { get; }

        public decimal PromotionAmount { get; }
    }
}
