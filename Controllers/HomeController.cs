using Microsoft.AspNetCore.Mvc;
using peterna.DAL;
using peterna.Models;

namespace peterna.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
         
        public IActionResult Index()
        {
            List<Service> services=_context.Services.ToList();
            return View(services);
        }
    }
}
