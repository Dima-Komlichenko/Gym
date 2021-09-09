using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Models
{
    public enum TrainingType { Solo, Individual, Group, Dances, Yoga }

    public class Training
    {
        public int Id { get; set; }
        public int CoachId { get; set; }
        public Coach Coach { get; set; }
        public List<Client> Clients { get; set; }
        public TrainingType TrainingType { get; set; }
        public DateTime[] WeekSchedule { get; set; } //расписание на неделю

    }
}
