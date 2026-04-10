

// Operations to be done on Event Entity

using CTOS.Web.Entities;
using CTOS.Web.Repositroies;

namespace CTOS.Web.Services {
    public class EventService(EventRepo eventRepo) {

        public Task<Event> GetEventByIdAsync(int id) {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<Event>> GetAllEventsAsync() {
            throw new NotImplementedException();
        }

        public Task<int> CreateEventAsync(Event @event) {
            throw new NotImplementedException();
        }
        
        public Task<int> UpdateEventAsync(int id, Event @event) {
            throw new NotImplementedException();
        }

        public Task<bool> DeletedEventAsync(int id) {
            throw new NotImplementedException();
        }


    }
}
