


// Controllers are functions that call the functions implemented in service (EventService)
// They are the links created to execute the functions

using CTOS.Web.Entities;
using CTOS.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace CTOS.Web.Controllers {

    [ApiController]
    [Route("api/[controller]")]
    public class EventController(EventService eventService) : ControllerBase {


        [HttpGet]
        [Route("Get-All")]
        public async Task<IActionResult> GetAllEvents() {
            var result = await eventService.GetAllEventsAsync();
            return Ok(result);
        }

        [HttpPost]
        [Route("Create-Event")]
        public async Task<IActionResult> CreateEvent(Event @event) {
            var result = await eventService.CreateEventAsync(@event);
            return Ok(result);
        }

        [HttpGet]
        [Route("Event/{id}")]
        public async Task<IActionResult> GetEventById(int id) {
            var result = await eventService.GetEventByIdAsync(id);
            return Ok(result);
        }

        [HttpPut]
        [Route("Event/{id}")]
        public async Task<IActionResult> UpdateEvent(int id, Event @event) {
            var result = await eventService.UpdateEventAsync(id, @event);
            return Ok(result);
        }

        [HttpDelete]
        [Route("Event/{id}")]
        public async Task<IActionResult> DeleteEvent(int id) {
            var result = await eventService.DeletedEventAsync(id);
            return Ok(result);
        }


    }
}
