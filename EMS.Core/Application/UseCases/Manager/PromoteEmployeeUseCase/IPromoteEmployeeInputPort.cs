using EMS.Core.Application.Ports;
using EMS.Core.Application.UseCases.Manager.PromoteEmployeeUseCase.Models;

namespace EMS.Core.Application.UseCases.Manager.PromoteEmployeeUseCase
{
    public interface IPromoteEmployeeInputPort : IInputPort<PromoteEmployeeInputModel, PromoteEmployeeOutputModel> { }
}
