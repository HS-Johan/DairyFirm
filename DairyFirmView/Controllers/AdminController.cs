using Microsoft.AspNetCore.Mvc;

namespace DairyFirmView.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
