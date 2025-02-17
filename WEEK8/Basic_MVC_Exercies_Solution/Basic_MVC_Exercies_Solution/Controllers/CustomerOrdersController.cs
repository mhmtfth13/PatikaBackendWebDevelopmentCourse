using Microsoft.AspNetCore.Mvc;

namespace Basic_MVC_Exercies_Solution.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
