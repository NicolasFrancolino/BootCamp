using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMVC.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
