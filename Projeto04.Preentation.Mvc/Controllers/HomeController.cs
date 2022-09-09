using Microsoft.AspNetCore.Mvc;

namespace Projeto04.Preentation.Mvc.Controllers
{
    public class HomeController : Controller
    {
        //GET: Home/Index
        public IActionResult Index()
        {
            return View();
        }
    }
}
