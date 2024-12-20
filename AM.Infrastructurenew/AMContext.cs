

using AM.ApplicationCore.Domain;
using AM.Infrastructure.Configurations;
using AM.Infrastructurenew.Configurations;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace AM.Infrastructurenew
{
    public class AMContext : DbContext
    {
        // Déclaration des DbSet pour vos entités
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Plan> Planes { get; set; }
        public DbSet<Staff> Staffs { get; set; }



        // Redéfinir la méthode OnConfiguring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configuration de la chaîne de connexion
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                Initial Catalog=AirportManagementDB;Integrated Security=true");

            base.OnConfiguring(optionsBuilder); // Appel de la méthode de base



        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Passenger>(entity =>
            {
                entity.OwnsOne(p => p.Name, name =>
                {
                    name.Property(n => n.FirstName).HasColumnName("FirstName");
                    name.Property(n => n.LastName).HasColumnName("LastName");
                });
            });

            // Appliquer les configurations Fluent API pour d'autres entités
            modelBuilder.ApplyConfiguration(new PlaneConfiguration());
            modelBuilder.ApplyConfiguration(new FlightConfiguration());
            modelBuilder.ApplyConfiguration(new PassengerConfiguration());
        }


        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);

            // Configurer DateTime pour qu'il soit de type "date"
            configurationBuilder.Properties<DateTime>()
                .HaveColumnType("date");
        }
    


}
}