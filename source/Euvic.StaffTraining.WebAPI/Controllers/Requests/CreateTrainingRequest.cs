using System;

namespace Euvic.StaffTraining.WebAPI.Controllers.Requests
{
    public class CreateTrainingRequest
    {
        public string Title { get; set; }
        public DateTime StartTime { get; set; }
        public long LecturerId { get; set; }

        public override string ToString()
        {
            return $"Title: {Title}, StartTime: {StartTime}, LecturerId: {LecturerId}";
        }
    }
}
