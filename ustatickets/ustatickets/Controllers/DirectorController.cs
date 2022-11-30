using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ustatickets.Data;

namespace ustatickets.Controllers
{
    public class DirectorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DirectorController(ApplicationDbContext context)
        {
            _context = context;

        }
        public async Task<IActionResult> Index()
        {

            var data = await _context.Director.ToListAsync();
            return View(data);
        }
    }
}
