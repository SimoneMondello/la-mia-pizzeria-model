using Microsoft.AspNetCore.Mvc;
using NetCore_01.Models;
using NetCore_01.Utils;

namespace NetCore_01.Controllers
{
    public class PostController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<Post> posts = PostData.GetPosts();
            return View("HomePage", posts);

        }
    }
}
