using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace EventTracker.Models
{
    public class EventContextMemory : DbContext
    {
        public EventContextMemory(DbContextOptions<EventContextMemory> options) : base(options)
            { }
        public DbSet<Event> Events { get; set; } = null!;
    }
}
