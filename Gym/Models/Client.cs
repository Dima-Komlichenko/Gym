using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Models
{
    public class Client 
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }

        public string TrainingId { get; set; } 
        public Training Training { get; set; }
        
    }
}
