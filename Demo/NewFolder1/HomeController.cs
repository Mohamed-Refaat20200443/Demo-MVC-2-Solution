using Microsoft.AspNetCore.Mvc;

namespace Demo.NewFolder1
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
            //return View( new Employee);
            //return View("Index");
        }
    }
}
