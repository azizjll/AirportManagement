using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructurenew.Configurations
{
    public class PassengerConfiguration : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            // Configurer le type d'entité détenu FullName
            builder.OwnsOne(p => p.Name);

            // Configurer les propriétés
            builder.Property(p => p.Name.FirstName).HasMaxLength(30).HasColumnName("PassFirstName");
            builder.Property(p => p.Name.LastName).IsRequired().HasColumnName("PassLastName");
        }
    }
}
