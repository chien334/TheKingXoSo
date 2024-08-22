using Microsoft.AspNetCore.Mvc;

namespace MyApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete() {
            return View();
        }

        public IActionResult Details() {
            return View();
        }

        [HttpPost]
        public IActionResult Create(object model)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(object model)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(object model)
        {
            return View();
        }

    }
}
