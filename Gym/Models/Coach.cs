using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Models
{
    public enum CoachPosition { Trainer, GeneralTrainer, SeniorTrainer}
    public class Coach
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }

        public Training Training { get; set; }
        public CoachPosition Position { get; set; }

        
    }
}
