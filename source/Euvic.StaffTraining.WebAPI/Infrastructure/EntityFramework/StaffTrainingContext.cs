using System.Reflection;
using Euvic.StaffTraining.WebAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace Euvic.StaffTraining.WebAPI.Infrastructure.EntityFramework
{
    public class StaffTrainingContext : DbContext
    {
        public const string Schema = "dbo";

        public StaffTrainingContext(DbContextOptions<StaffTrainingContext> options)
            : base(options)
        {
        }

        DbSet<Attendee> Attendees { get; set; } // plurar name convention
        DbSet<Lecturer> Lecturers { get; set; }
        DbSet<Technology> Technologies { get; set; }
        DbSet<Training> Trainings { get; set; }
        DbSet<TrainingAttendeeStatus> TrainingAttendeeStatuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // -- Bulk registration
            modelBuilder.ApplyConfigurationsFromAssembly(
                Assembly.GetAssembly(typeof(StaffTrainingContext)
                ));

            // -- Single registration
            // modelBuilder.ApplyConfiguration(new AttendeeConfiguration());
        }
    }
}
