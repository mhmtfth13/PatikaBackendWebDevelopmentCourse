using Microsoft.AspNetCore.Mvc;

namespace Basic_MVC_Exercies_Solution.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
