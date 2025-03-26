using Microsoft.AspNetCore.Mvc;

namespace MVC_DEMO.Controllers
{
    public class MovieController: Controller
    {
        public string Index(int id)
        {
            return $"Hello, {id}";
        }
        public IActionResult GetMovie(int? Id, string name)
        {
            if (!Id.HasValue || Id == 0)
                return BadRequest("Invalid Movie ID.");
            else if (Id < 10)
                return NotFound("Movie not found.");
            else
                return Content($"Movie {Id}, Name: {name}");
        }
        public IActionResult TestRedirectToAction()
        {
            return Redirect("https://www.facebook.com/");
        }
        public IActionResult TestRedirectToGetMovies()
        {
            return RedirectToAction("GetMovie", new { id = 10, name = "movie1" });
            return Redirect("https://localhost:7247/Movies/GetMovie/1?name=dd");        }
    }
}
