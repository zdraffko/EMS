using System.Threading.Tasks;

using EMS.Core.Application.Infrastructure;
using EMS.Core.Domain.Entities.ManagerAggregate;
using EMS.Infrastructure.Identity;
using EMS.Web.ViewModels;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(
            IUserService userService,
            SignInManager<ApplicationUser> signInManager)
            => (_userService, _signInManager) = (userService, signInManager);

        [HttpGet]
        public IActionResult Register() => View();

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var manager = new Manager(model.FirstName, model.LastName, model.Age, model.Email);

            var hasSucceeded = await _userService.CreateUserAsync(manager, model.Password);

            if (hasSucceeded)
                return RedirectToAction("Index", "Home");

            return View(model);
        }
    }
}