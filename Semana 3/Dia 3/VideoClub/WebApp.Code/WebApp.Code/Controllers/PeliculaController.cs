using Microsoft.AspNetCore.Mvc;
using WebApp.Code.Data;

namespace WebApp.Code.Controllers
{
    public class PeliculaController : Controller
    {
        private readonly AppDbContext _context;

        public PeliculaController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
