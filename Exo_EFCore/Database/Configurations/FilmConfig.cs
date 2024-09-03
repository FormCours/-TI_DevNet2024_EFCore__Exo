using Exo_EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_EFCore.Database.Configurations
{
    public class FilmConfig : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            // Colonnes
            builder.Property(f => f.FilmId)
                   .ValueGeneratedOnAdd();

            builder.Property(f => f.Titre)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(f => f.AnneeSortie)
                   .IsRequired();

            builder.Property(f => f.Realisateur)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(f => f.ActeurPrincipal)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(f => f.Genre)
                   .HasMaxLength(100)
                   .IsRequired();

            // Indexes
            builder.HasKey(f => f.FilmId)
                   .HasName("PK_Film")
                   .IsClustered();

            builder.HasIndex(f => f.Titre)
                   .HasDatabaseName("IX_Film__Titre")
                   .IsUnique();

            // Contraintes
            builder.ToTable(t =>
            {
                t.HasCheckConstraint("CK_Film__AnneeSortie", "[AnneeSortie] > 1975");
            });
        }
    }
}