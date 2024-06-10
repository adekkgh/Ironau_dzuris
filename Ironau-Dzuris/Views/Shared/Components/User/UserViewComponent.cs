using Ironau_Dzuris.Db;
using Ironau_Dzuris.Db.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Ironau_Dzuris.Views.Shared.Components.User
{
    public class UserViewComponent : ViewComponent
    {
        private readonly IUsersRepository usersRepository;
        private readonly IHttpContextAccessor httpContextAccessor;

        public UserViewComponent(IUsersRepository usersRepository, IHttpContextAccessor httpContextAccessor)
        {
            this.usersRepository = usersRepository;
            this.httpContextAccessor = httpContextAccessor;
        }

        public IViewComponentResult Invoke()
        {
            var id = httpContextAccessor.HttpContext.Request.Cookies["user"];
            if (id == null)
            {
                return View("User", "");
            }
            var user = usersRepository.FindById(Guid.Parse(id));
            return View("User", user.Name);
        }
    }
}
