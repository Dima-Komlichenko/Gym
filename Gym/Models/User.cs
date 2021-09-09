using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Models
{
    public enum Sex { Male, Female }
   
    public class User : IdentityUser
    {
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public Sex Sex { get; set; }
        public IdentityRole Role { get; set; }
    }
}
