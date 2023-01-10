using TestTickets.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace TestTickets.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Refund> Refunds { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Route> Routes { get; set; }
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();

            modelBuilder.Entity<Ticket>(eb => eb.HasKey(p => new { p.Id }));
            modelBuilder.Entity<Ticket>().HasOne(t => t.Passenger).WithMany(p => p.Tickets);
            modelBuilder.Entity<Ticket>().HasMany(t => t.Routes).WithMany(r => r.Tickets);
            ;
            modelBuilder.Entity<Refund>(eb =>eb.HasKey(p => p.Id));

            modelBuilder.Entity<Passenger>(eb => eb.HasKey(p => p.Id));
            modelBuilder.Entity<Passenger>().HasMany(p => p.Tickets).WithOne(t => t.Passenger);

            modelBuilder.Entity<Route>(eb => eb.HasKey(p => p.Id));
            modelBuilder.Entity<Route>().HasMany(r => r.Tickets).WithMany(t => t.Routes);

            base.OnModelCreating(modelBuilder);
        }
    }
}

/*
 Add-Migration AddRelations1 -Project TestTickets.Data
 */