using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AM.Infrastructure.Configurations
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            // Relation many-to-many entre Flight et Passenger (sans table de jonction explicite)
            builder.HasMany(f => f.Passengers)
                   .WithMany(p => p.Flights);

            // Relation one-to-many entre Flight et Plane
            builder.HasOne(f => f.Plan)
                   .WithMany()
                   .HasForeignKey(f => f.PlaneId);
        }
    }
}
