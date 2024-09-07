using Microsoft.AspNetCore.Mvc;

namespace Demo.NewFolder1
{
    public class AuthoController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Signin() {

            return View();
        }

        public IActionResult Signup()
        {

            return View();
        }
    }
}
