using EventModule.Data;
using EventModule.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventModule.Services.Events
{
    public class EventRep : IEvents
    {
        private readonly EventDbContext _context;

        public EventRep(EventDbContext context)
        {
            _context = context;
        }
        public async Task<Event> CreateEvent(Event _event)
        {
            _context.Events.Add(_event);
            await _context.SaveChangesAsync();
            return _event;
        }

        public async Task<int> DeleteEvent(Event _event)
        {
            _context.Events.Remove(_event);
            return await _context.SaveChangesAsync();
        }

        public async Task<Event> GetEventById(int id)
        {
            return await _context.Events.FirstOrDefaultAsync(a=>a.EventId==id);

        }

        public async Task<IEnumerable<Event>> GetEventsList()
        {
            return await _context.Events.ToListAsync();
        }

        public  async Task<int> UpdateEvent(Event _event)
        {
            _context.Events.Update(_event);
            return await _context.SaveChangesAsync();
        }
    }
}
