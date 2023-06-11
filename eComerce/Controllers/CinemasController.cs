using eComerce.Data;
using eComerce.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eComerce.Controllers
{
    public class CinemasController : Controller
    {
        private readonly CinemaService _service;
        public CinemasController(CinemaService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allCinemas = await _service.GetAllAsync();
            return View(allCinemas);
        }
    }
}
