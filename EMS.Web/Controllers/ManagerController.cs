﻿using System;
using System.Threading.Tasks;

using EMS.Core.Application.Gateways;
using EMS.Core.Application.Infrastructure;
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
        private readonly IUserService _userService;

        public ManagerController(
            IPromoteEmployeeInputPort promoteEmployeeInputPort,
            PromoteEmployeePresenter promoteEmployeePresenter,
            IManagerRepository managerRepository,
            IUserService userService)
        {
            _promoteEmployeeInputPort = promoteEmployeeInputPort;
            _promoteEmployeePresenter = promoteEmployeePresenter;
            _managerRepository = managerRepository;
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            var managerGuid = await _userService.GetUserGuidAsync(User);

            var employees = _managerRepository
                .GetAllEmployees(managerGuid);

            return View(employees);
        }


        public async Task<IActionResult> PromoteEmployee(Guid employeeGuid, decimal promotionAmpunt)
        {
            await _promoteEmployeeInputPort.Handle(
                new PromoteEmployeeInputModel(User, employeeGuid, promotionAmpunt),
                _promoteEmployeePresenter);

            return _promoteEmployeePresenter.Result;
        }
    }
}