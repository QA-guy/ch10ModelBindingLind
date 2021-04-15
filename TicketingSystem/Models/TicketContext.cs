using Microsoft.EntityFrameworkCore;

namespace TicketingSystem.Models
{
    public class TicketContext : DbContext
    {
        public TicketContext(DbContextOptions<TicketContext> options)
            : base(options) { }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Sprint> Sprints { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sprint>().HasData(
                new Sprint { SprintId = "janone",Name = "JanOne"},
                new Sprint { SprintId = "jantwo",Name = "JanTwo"},
                new Sprint { SprintId = "febone",Name = "FebOne"},
                new Sprint { SprintId = "febtwo",Name = "FebTwo"},
                new Sprint { SprintId = "marone",Name = "MarOne"},
                new Sprint { SprintId = "martwo",Name = "MarTwo"},
                new Sprint { SprintId = "aprone",Name = "AprOne"},
                new Sprint { SprintId = "aprtwo",Name = "AprTwo"},
                new Sprint { SprintId = "mayone",Name = "MayOne"},
                new Sprint { SprintId = "maytwo",Name = "MayTwo"},
                new Sprint { SprintId = "junone",Name = "JunOne"},
                new Sprint { SprintId = "juntwo",Name = "JunTwo"},
                new Sprint { SprintId = "julone",Name = "JulOne"},
                new Sprint { SprintId = "jultwo",Name = "JulTwo"},
                new Sprint { SprintId = "augone",Name = "AugOne"},
                new Sprint { SprintId = "augtwo",Name = "AugTwo"},
                new Sprint { SprintId = "sepone",Name = "SepOne"},
                new Sprint { SprintId = "septwo",Name = "SepTwo"},
                new Sprint { SprintId = "octone",Name = "OctOne"},
                new Sprint { SprintId = "octtwo",Name = "OctTwo" },
                new Sprint { SprintId = "novone",Name = "NovOne"},
                new Sprint { SprintId = "novtwo",Name = "NovTwo"},
                new Sprint { SprintId = "decone",Name = "DecOne"},
                new Sprint { SprintId = "dectwo",Name = "DecTwo"}

                );

            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = "todo",Name = "To Do"},
                new Status { StatusId = "inprogress",Name = "In Progress"},
                new Status { StatusId = "qualityassurance",Name = "Quality Assurance"},
                new Status { StatusId = "done",Name = "Done"}
                );
        }

    }
}
