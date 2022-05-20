using Microsoft.AspNetCore.Mvc;
using WebApp.Code.Data;

namespace WebApp.Code.Controllers
{
    public class AlquilerController : Controller
    {
        private readonly AppDbContext _context;

        public AlquilerController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
