using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Euvic.StaffTraining.WebAPI.Controllers
{
    [Route("api/attendees")]
    [ApiController]
    public class AttendeesController : ControllerBase
    {
        private readonly ILogger<AttendeesController> _logger;

        public AttendeesController(ILogger<AttendeesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAttendies()
        {
            throw new System.Exception("Database connection error");

            return Ok();
        }

        [HttpPost]
        public IActionResult CreateAttendee()
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAttendee([FromRoute] long id)
        {
            _logger.LogInformation($"Atendee with id {id} has been updated");

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAttendee([FromRoute] long id)
        {
            _logger.LogInformation($"Atendee with id {id} has been deleted");

            return NoContent();
        }
    }
}
