using Microsoft.AspNetCore.Mvc;

namespace Look_For_It.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
