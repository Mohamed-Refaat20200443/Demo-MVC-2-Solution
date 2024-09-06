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
        [HttpGet]
        //[AcceptVerbs("Get")]
        public string GetMovie(int id) {


            return $"Movie with Id : {id}";
        }


        //[ActionName("ConfirmGetMovie")]
        //public string GetMovie(String Name)
        //{


        //    return $"Movie with Id : {Name}";
        //}
    }
}
