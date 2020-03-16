using EMS.Core.Application.Ports;
using EMS.Core.Application.UseCases.Manager.PromoteEmployeeUseCase.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace EMS.Web.Presenters
{
    public class PromoteEmployeePresenter : IOutputPort<PromoteEmployeeOutputModel>
    {
        public ViewResult Result { get; private set; } = new ViewResult();

        public void Success(PromoteEmployeeOutputModel output)
        {
            Result.ViewName = "PromoteEmployee";
            Result.ViewData =
                new ViewDataDictionary(new EmptyModelMetadataProvider(), new ModelStateDictionary())
                {
                    Model = output
                };
        }

        public void Fail(string message = null) => Result.ViewName = "Error";
    }
}
