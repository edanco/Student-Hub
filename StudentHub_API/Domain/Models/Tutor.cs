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
        
        //relación con Schedule y plataform

        //// relationships
        //public int CareerId { get; set; }
        //public Career Career { get; set; }

        //public List<ExpertTopic> ExpertTopics { get; set; }
        public List<Schedule> Shedules { get; set; }
        //public List<Session> Sessions { get; set; }
        //public List<TutorReservation> TutorReservations { get; set; }
        //public List<SessionMaterial> SessionMaterials { get; set; }
    }
}
