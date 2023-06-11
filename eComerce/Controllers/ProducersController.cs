using eComerce.Data;
using eComerce.Data.Services;
using eComerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eComerce.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducerService _service;

        public ProducersController(IProducerService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _service.GetAllAsync();
            return View(allProducers);
        }

        //Get: Producers/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

        // Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Biography")] Producer producer)
        {
            if (!ModelState.IsValid)
            {
                //If the input data is not valid, return the same view, but with the errors
                return View(producer);
            }

            //Call the service to add the new actor to the database
            await _service.AddAsync(producer);

            return RedirectToAction(nameof(Index));
        }

        // Get: Actors/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureURL,Biography")] Producer producer)
        {
            if (!ModelState.IsValid)
            {
                //If the input data is not valid, return the same view, but with the errors
                return View(producer);
            }

            //Call the service to add the new actor to the database
            await _service.UpdateAsync(id, producer);
            return RedirectToAction(nameof(Index));
        }
    }
}
