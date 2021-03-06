using System;
using System.Collections.Generic;
using Euvic.StaffTraining.WebAPI.Infrastructure.EntityFramework.Abstractions;

namespace Euvic.StaffTraining.WebAPI.Entities
{
    public class Lecturer : IUpdateDate, ICreateDate
    {
        public long Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public ICollection<Training> Trainings { get; set; }
        public int TrainingsCount => Trainings?.Count ?? 0;
    }
}
