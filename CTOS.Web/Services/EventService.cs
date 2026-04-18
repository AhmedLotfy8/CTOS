

// Operations to be done on Event Entity

using CTOS.Web.Entities;
using CTOS.Web.Repositroies;
using Microsoft.Extensions.Logging;

namespace CTOS.Web.Services {
    public class EventService(EventRepo eventRepo) {

        public async Task<Event?> GetEventByIdAsync(int id) {

            var result = await eventRepo.GetByIdAsync(id);

            if (result is null)
                throw new Exception($"Event with Id:{id} is not found");

            return result;
        }

        public async Task<IEnumerable<Event>> GetAllEventsAsync() {
            return await eventRepo.GetAllAsync();
        }

        public async Task<int> CreateEventAsync(Event evenT) {

            evenT.Id = 0;

            await eventRepo.AddAsync(evenT);
            await eventRepo.SaveChangesAsync();
            return evenT.Id;
        }

        public async Task<int> UpdateEventAsync(int id, Event evenT) {

            if (id <= 0) return 0;

            var existingEvent = await eventRepo.GetByIdAsync(id);
            if (existingEvent == null) return 0;

            // Update properties
            existingEvent.EventId = evenT.EventId;
            existingEvent.EventName = evenT.EventName;
            existingEvent.Location = evenT.Location;
            existingEvent.Priority = evenT.Priority;
            existingEvent.Description = evenT.Description;

            eventRepo.UpdateAsync(existingEvent);
            await eventRepo.SaveChangesAsync();

            return existingEvent.Id;
        }

        public async Task<bool> DeletedEventAsync(int id) {
            var existingEvent = await eventRepo.GetByIdAsync(id);
            if (existingEvent == null) return false;

            eventRepo.DeleteAsync(existingEvent);
            await eventRepo.SaveChangesAsync();

            return true;
        }
    }

}
