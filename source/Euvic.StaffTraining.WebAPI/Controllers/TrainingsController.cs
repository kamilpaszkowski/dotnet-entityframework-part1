using System.IO;
using System.Threading.Tasks;
using Euvic.StaffTraining.WebAPI.Controllers.Requests;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Euvic.StaffTraining.WebAPI.Controllers
{
    [Route("api/trainings")]
    [ApiController]
    public class TrainingsController : ControllerBase
    {
        private readonly ILogger<TrainingsController> _logger;
        private readonly IWebHostEnvironment _environment;

        public TrainingsController(
            ILogger<TrainingsController> logger,
            IWebHostEnvironment environment)
        {
            _logger = logger;
            _environment = environment;
        }

        #region Trainings

        [HttpGet]
        public IActionResult GetTrainings([FromQuery] GetTrainingsRequest request)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateTraining([FromBody] CreateTrainingRequest request)
        {
            _logger.LogInformation($"CreateTraining was executed with parameters {request}");

            // Create training code here

            return Ok();
        }

        [HttpPost("{id}/presentation")]
        public async Task<IActionResult> UploadTrainingPresentation([FromForm] UploadTrainingPresentationRequest request)
        {
            var rootPath = _environment.ContentRootPath;

            using (var stream = System.IO.File.Create(Path.Combine(rootPath, $"uploaded_{request.Presentation.FileName}")))
            {
                await request.Presentation.CopyToAsync(stream);
            }

            // Upload presentation code here

            _logger.LogInformation($"Training presentation for file {request.Presentation.FileName} was uploaded");

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTraining([FromRoute] long id, [FromBody] UpdateTrainingRequest request)
        {
            _logger.LogInformation($"UpdateTraining for trainingId {id} was executed with parameters {request}");

            // Update code here

            return NoContent();
        }

        [HttpPut("{id}/lecturer")]
        public IActionResult ChangeTrainingLecturer([FromRoute] long id, [FromBody] long lecturerId)
        {
            _logger.LogInformation($"Training with id {id} changed lecturer to {lecturerId}");

            // Change lecturer code here

            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteTraining([FromRoute] long id)
        {
            // Change lecturer code here

            return NoContent();
        }

        #endregion Trainings

        #region Attendees

        [HttpGet("{id}/attendees")]
        public IActionResult GetTrainingAttendees([FromRoute] long id)
        {
            // Get attendees code here

            return Ok();
        }

        [HttpPost("{id}/attendees")]
        public IActionResult AddTrainingAttendee([FromRoute] long id, [FromBody] long attendeeId)
        {
            // Add attendee code here

            return Ok();
        }

        [HttpDelete("{id}/attendees/{attendeeId}")]
        public IActionResult DeleteTrainingAttendees([FromRoute] long id, [FromRoute] long attendeeId)
        {
            // Add attendee code here

            return Ok();
        }



        #endregion Attendees

    }
}
