using Microsoft.AspNetCore.Mvc;

namespace EduClick.Controllers
{
    public class Usuarios : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
