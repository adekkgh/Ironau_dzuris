using Look_For_It.Db;
using Look_For_It.Db.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Linq;
using System.Net;

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
            if (Request.Cookies["user"] != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public IActionResult LogOut()
        {
            foreach (var cookie in Request.Cookies.Keys)
            {
                Response.Cookies.Delete(cookie);
            }
            return RedirectToAction("LogIn", "Auth");
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
                ModelState.AddModelError("", "Please make sure your password doesn't match your name");
            }

            var newUser = new User
            {
                Name = name,
                Email = email,
                Password = newPassword
            };
            usersRepository.Add(newUser);

            CookieOptions option = new CookieOptions();
            option.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Append("user", newUser.Id.ToString(), option);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult LogIntoAccount(string email, string password, bool remember)
        {
            var user = usersRepository.FindByEmail(email);
            var isPasswordValid = usersRepository.IsPasswordValid(email, password);
            if (user == null || !isPasswordValid)
            {
                return RedirectToAction("LogIn", "Auth");
            }
            CookieOptions option = new CookieOptions();
            if (remember)
            {
                option.Expires = DateTime.Now.AddDays(7);
            }
            else
            {
                option.Expires = DateTime.Now.AddDays(1);
            }
            // TODO: upload user's role to cookies
            Response.Cookies.Append("user", user.Id.ToString(), option);
            return RedirectToAction("Index", "Home");
        }
    }
}
