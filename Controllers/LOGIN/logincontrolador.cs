using Microsoft.AspNetCore.Mvc;

namespace EduClick.Controllers.LOGIN
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string correo, string clave)
        {
            if (correo == "admin@educlick.com" && clave == "1234")
            {
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Correo o contraseña incorrectos";
            return View();
        }
    }
}
