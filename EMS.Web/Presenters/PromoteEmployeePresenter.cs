using EMS.Core.Application.Ports;
using EMS.Core.Application.UseCases.Manager.PromoteEmployeeUseCase.Models;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Web.Presenters
{
    public class PromoteEmployeePresenter : IOutputPort<PromoteEmployeeOutputModel>
    {
        public IActionResult Result { get; private set; }

        public void Success(PromoteEmployeeOutputModel output) => Result = new OkObjectResult(output);

        public void Fail(string message = null) => Result = new NotFoundObjectResult(message);
    }
}
