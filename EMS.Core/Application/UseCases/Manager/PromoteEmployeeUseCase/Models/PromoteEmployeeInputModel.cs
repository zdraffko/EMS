using System;

namespace EMS.Core.Application.UseCases.Manager.PromoteEmployeeUseCase.Models
{
    public class PromoteEmployeeInputModel
    {
        public PromoteEmployeeInputModel(Guid employeeGuid, decimal promotionAmount)
            => (EmployeeGuid, PromotionAmount) = (employeeGuid, promotionAmount);

        public Guid EmployeeGuid { get; }

        public decimal PromotionAmount { get; }
    }
}
