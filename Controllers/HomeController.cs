using Microsoft.AspNetCore.Mvc;

namespace LayoutDemo.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
         [Route("about")]
        public IActionResult About()
        {
            return View();
        }
        [Route("contact")]
        public IActionResult Contact()
        {
            return View();
        }
        [Route("workexperience")]
        public IActionResult Workexperience()
        {
            return View();
        }
    }
}