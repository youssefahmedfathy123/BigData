using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Data;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        

        public IActionResult Details(string id) 
        {
            if (string.IsNullOrEmpty(id))
            {
                return RedirectToAction("Index"); 
            }

            var result = _context.Urls.Where(x => x.Word == id);

            if (result == null)
            {
                return NotFound(); 
            }

            return View(result); 
        }

    }
}

