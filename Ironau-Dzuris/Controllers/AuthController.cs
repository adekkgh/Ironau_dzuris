using Ironau_Dzuris.Db;
using Ironau_Dzuris.Db.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Linq;
using System.Net;

namespace Ironau_Dzuris.Controllers
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

        public IActionResult CreateNewAccount(string name, string email, string newPassword)
        {
            var existingUser = usersRepository.FindByEmail(email);
            if(existingUser == null)
            {
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
            else
            {
                ModelState.AddModelError(String.Empty, "Пользователь с таким логином уже существует");
                return View("SignUp");
            }
        }

        public IActionResult LogIntoAccount(string email, string password, bool remember)
        {
            var user = usersRepository.FindByEmail(email);
            var isPasswordValid = usersRepository.IsPasswordValid(email, password);

            if (user == null)
            {
                ModelState.AddModelError(String.Empty, "Пользователя с таким логином не существует");
                return View("Login");
                //return RedirectToAction("LogIn", "Auth");
            }
            if (!isPasswordValid)
            {
                ModelState.AddModelError(String.Empty, "Неверный пароль");
                return View("Login");
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
