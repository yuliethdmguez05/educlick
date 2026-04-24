using Microsoft.AspNetCore.Mvc;

namespace EduClick.Controllers
{
    public class SecretariaController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
