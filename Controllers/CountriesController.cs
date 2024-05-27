using Microsoft.AspNetCore.Mvc;
using WebIntroEmpty.Models.Contexts;

namespace WebIntroEmpty.Controllers
{
    public class CountriesController : Controller
    {
        private readonly DataContext db;

        public CountriesController(DataContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {

            var countries=db.Countries.ToList();

            return View(countries);


        }
    }
}
