using Microsoft.AspNetCore.Mvc;

namespace EMS.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
