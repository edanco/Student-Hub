using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentHub_API.Domain.Models
{
    public class Tutor
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double PricePerHour { get; set; }
        
        //relación con Schedule, Course
        //// relationships
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public List<Schedule> Schedules { get; set; }
        //public List<Session> Sessions { get; set; }
        //public List<TutorReservation> TutorReservations { get; set; }
        //public List<SessionMaterial> SessionMaterials { get; set; }
    }
}
