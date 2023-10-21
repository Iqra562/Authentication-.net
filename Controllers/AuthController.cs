using Microsoft.AspNetCore.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(UserRegisterRequest request)
        {
            if (ModelState.IsValid)

            {
                return Ok(request);

            }
            else
            {
                return View(request);
            }

        }
    }
}
