using eComerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eComerce.Controllers
{
    public class CinemaCoontroller : Controller
    {
        private readonly AppDbContext _context;
        public CinemaCoontroller(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Cinemas.ToListAsync();
            return View();
        }
    }
}
