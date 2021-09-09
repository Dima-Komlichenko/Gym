using Gym.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Gym.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public List<Client> Clients { get; set; }
        public List<Coach> Coach { get; set; }
        public List<Admin> Admins { get; set; }
        public List<Training> Trainings { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Training>(t =>
            {
                t.Property(e => e.WeekSchedule).HasConversion(
                    set => (set != null) ? JsonSerializer.Serialize(set, null) : null,
                    str => JsonSerializer.Deserialize<DateTime[]>(str, null));
            });
        }

        public DbSet<Gym.Models.Client> Client { get; set; }

        public DbSet<Gym.Models.Coach> Coach_1 { get; set; }

    }
}
