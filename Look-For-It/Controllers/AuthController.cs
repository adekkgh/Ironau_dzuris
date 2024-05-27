using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Look_For_It.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult LogIn()
        {
            return View();
        }

        public IActionResult LogOut()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        public string CreateNewAccount(string name, string lastName, string phone, string email, string newPassword, string newPassportConfirmation, bool agreement)
        {
            if (agreement == false)
            {
                ModelState.AddModelError("", "Please read and agree to our privacy policy");
            }
            else if (name == newPassword || lastName == newPassword)
            {
                ModelState.AddModelError("", "Please make sure your password doesn't match your name or lastname");
            }

            return "temp";
        }

        public IActionResult LogIntoAccount(string email, string password, bool remember)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
