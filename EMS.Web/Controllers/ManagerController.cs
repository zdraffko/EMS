using System;
using System.Threading.Tasks;

using EMS.Core.Application.Gateways;
using EMS.Core.Application.UseCases.Manager.PromoteEmployeeUseCase;
using EMS.Core.Application.UseCases.Manager.PromoteEmployeeUseCase.Models;
using EMS.Web.Presenters;

using Microsoft.AspNetCore.Mvc;

namespace EMS.Web.Controllers
{
    public class ManagerController : Controller
    {
        private readonly IPromoteEmployeeInputPort _promoteEmployeeInputPort;
        private readonly PromoteEmployeePresenter _promoteEmployeePresenter;
        private readonly IManagerRepository _managerRepository;

        public ManagerController(
            IPromoteEmployeeInputPort promoteEmployeeInputPort,
            PromoteEmployeePresenter promoteEmployeePresenter,
            IManagerRepository managerRepository)
        {
            _promoteEmployeeInputPort = promoteEmployeeInputPort;
            _promoteEmployeePresenter = promoteEmployeePresenter;
            _managerRepository = managerRepository;
        }

        public IActionResult Index()
        {
            var employees = _managerRepository
                .GetAllEmployees(Guid.Parse("783E92F6-85C0-48CD-9A09-C25BEAFC570C"));

            return View(employees);
        }


        public async Task<IActionResult> PromoteEmployee(Guid employeeGuid, decimal promotionAmpunt)
        {
            await _promoteEmployeeInputPort.Handle(
                new PromoteEmployeeInputModel(employeeGuid, promotionAmpunt),
                _promoteEmployeePresenter);

            return _promoteEmployeePresenter.Result;
        }
    }
}