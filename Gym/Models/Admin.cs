using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Models
{
    public enum AdminPosition { Manager, GeneralManager}
    public class Admin
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public AdminPosition Position { get; set; }

    }
}
