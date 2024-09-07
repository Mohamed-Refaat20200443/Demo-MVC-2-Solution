using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Demo.NewFolder1
{
    public class MoviesController :Controller
    {
        [HttpGet]
        public string Index()
        {
            return "All Movies";
        }



        //[Authorize] // هل فيه Token ?
        //[HttpGet]
        //[AcceptVerbs("Get")]
        //public string GetMovie(int id) {


        //    return $"Movie with Id : {id}";
        //}


        //[ActionName("ConfirmGetMovie")]
        //public string GetMovie(String Name)
        //{


        //    return $"Movie with Id : {Name}";
        //}

        [HttpGet] // GET: baseUrl/Movies/GetMovie/{id}
        public IActionResult GetMovie(int id)
        {
            if (id == 0)
            {
                // return new BadRequestResult();
                return BadRequest();
            }

            if (id == 100)
            {
                // return new NotFoundResult();
                return NotFound();
            }

            // ContentResult result = new ContentResult();
            return Content($"<h1> Movie with Id: {id} </h1>", "text/html");
        }



        public IActionResult Hamda()
        {
            // RedirectResult result = new RedirectResult("https://wuzzuf.net/jobs/egypt");


            RedirectToActionResult result = new RedirectToActionResult("GetMovie", "Movies", new { id = 10 });

            return result;
        }
    }
}
