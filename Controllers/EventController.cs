using EventManagementMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EventManagementMVC.Controllers
{
    public class EventController : Controller
    {
        private readonly EventDbContext _dbContext;

        public EventController(EventDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IActionResult<Event>> AddAsync()
        {
            _dbContext.Events.Add(events);
            await _dbContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetEvent), new { Id = events.Id }, events);

            return View();
        }
    }
}
