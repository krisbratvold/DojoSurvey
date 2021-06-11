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
        public ViewResult ProcessPost(Post newPost)
        {
            return View("Result", newPost);
        }
    }
}