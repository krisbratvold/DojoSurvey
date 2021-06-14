using DojoSurvey.Models;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpPost("/process/post")]
        public IActionResult ProcessPost(Post newPost)
        {
            if (ModelState.IsValid)
            {
                // do somethng!  maybe insert into db?  then we will redirect
                return RedirectToAction("Result", new{
                    name = newPost.Name,
                    location = newPost.Location,
                    language = newPost.Language,
                    comment = newPost.Comment
                });
            }
            else
            {
                // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
                return View("Index");
            }
        }
        [HttpGet("/result")]
        public IActionResult Result(string name, string location, string language, string comment)
        {
            Post result = new Post()
            {
                Name=name,
                Location = location,
                Language = language,
                Comment = comment
            };
            return View("Result", result);
        }
    }
}