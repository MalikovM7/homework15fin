using Microsoft.AspNetCore.Mvc;

namespace WebIntroEmpty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



    }
}
