using Microsoft.AspNetCore.Mvc;

namespace EMS.Web.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult PromoteEmployee()
        {
            return View();
        }
    }
}