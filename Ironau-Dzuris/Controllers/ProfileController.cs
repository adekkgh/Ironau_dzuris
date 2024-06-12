using Ironau_Dzuris.Db;
using Ironau_Dzuris.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Ironau_Dzuris.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IUsersRepository usersRepository;
        private readonly IHttpContextAccessor httpContextAccessor;

        public ProfileController(IHttpContextAccessor httpContextAccessor, IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
            this.httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            if (Request.Cookies["user"] == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var userId = httpContextAccessor.HttpContext.Request.Cookies["user"];
            var user = usersRepository.FindById(Guid.Parse(userId));
            return View(Mapping.UserToUserViewModel(user));
        }

        public IActionResult ChangeEmailView()
        {
            if (Request.Cookies["user"] == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        public IActionResult ChangeEmail(string email)
        {
            if (Request.Cookies["user"] == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var userId = httpContextAccessor.HttpContext.Request.Cookies["user"];
            var user = usersRepository.FindById(Guid.Parse(userId));

            if(user.Email == email)
            {
                ModelState.AddModelError(String.Empty, "Email совпадает с прежним");
                return View("ChangeEmailView");
            }
            else
            {
                var existingUser = usersRepository.FindByEmail(email);
                if (existingUser != null)
                {
                    ModelState.AddModelError(String.Empty, "Пользователь с таким email уже существует");
                    return View("ChangeEmailView");
                }
                else
                {
                    usersRepository.ChangeEmail(user, email);
                }
            }

            return RedirectToAction("Index");
        }

        public IActionResult ChangePasswordView()
        {
            if (Request.Cookies["user"] == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        public IActionResult ChangePassword(string oldPassword, string newPassword, string newPasswordConfirmation)
        {
            if (Request.Cookies["user"] == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var userId = httpContextAccessor.HttpContext.Request.Cookies["user"];
            var user = usersRepository.FindById(Guid.Parse(userId));

            if(user.Password != oldPassword)
            {
                ModelState.AddModelError(String.Empty, "Прежний пароль неверен");
                return View("ChangePasswordView");
            }
            else if(newPassword == oldPassword)
            {
                ModelState.AddModelError(String.Empty, "Прежний пароль неверен");
                return View("ChangePasswordView");
            }
            else if (newPassword != newPasswordConfirmation)
            {
                ModelState.AddModelError(String.Empty, "Прежний пароль неверен");
                return View("ChangePasswordView");
            }
            else
            {
                usersRepository.ChangePassword(user, newPassword);
            }

            return RedirectToAction("Index");
        }
    }
}
