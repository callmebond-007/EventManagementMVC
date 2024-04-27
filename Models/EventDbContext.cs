using Microsoft.EntityFrameworkCore;

namespace EventManagementMVC.Models
{
    public class EventDbContext: DbContext
    {
        public EventDbContext(DbContextOptions<EventDbContext> options) : base(options)
        {

        }
        public DbSet<Event> Events { get; set; }
    }
}
