using Look_For_It.Db;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Look_For_It.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUsersRepository usersRepository;

        public AuthController(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }

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

        public IActionResult CreateNewAccount(string name, string email, string newPassword, string newPassportConfirmation, bool agreement)
        {
            if (agreement == false)
            {
                ModelState.AddModelError("", "Please read and agree to our privacy policy");
            }
            else if (name == newPassword)
            {
                ModelState.AddModelError("", "Please make sure your password doesn't match your name or lastname");
            }

            usersRepository.Add(new Db.Models.User
            {
                Name = name,
                Email = email,
                Password = newPassword
            });

            return RedirectToAction("Index", "Home");
        }

        public IActionResult LogIntoAccount(string email, string password, bool remember)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
