using Kamu.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kamu.Controllers
{
    public class Authentication : Controller
    {

        [HttpPost()]
        public IActionResult Login(LoginViewModel loginDTO)
        {
            Console.WriteLine(loginDTO.Email);
            return RedirectToAction("Dashboard","Home");
        }


        [HttpPost]
        public IActionResult CreateUser(SignUpViewModel signUpDTO)
        {
            Console.WriteLine(signUpDTO.Email);
            return RedirectToAction("Dashboard","Home");
        }
    }
}
