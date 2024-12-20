using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AM.ApplicationCore.Domain; // Assurez-vous d'importer le bon namespace pour la classe Plane

namespace AM.Infrastructurenew.Configurations
{
    public class PlaneConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            // Configurer la clé primaire pour la table "Plane"
            builder.HasKey(p => p.PlaneId);

            // Spécifier le nom de la table dans la base de données
            builder.ToTable("MyPlanes");

            // Configurer la colonne "Capacity" avec un nom personnalisé
            builder.Property(p => p.Capacity).HasColumnName("PlaneCapacity");
        }
    }
}
