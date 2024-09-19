using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StructureEFSimple.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureEFSimple.DAL.Database.Configurations
{
    public class PersonneConfig : IEntityTypeConfiguration<Personne>
    {
        public void Configure(EntityTypeBuilder<Personne> builder)
        {
            builder.ToTable("Personne");

            // Id indiqué explicitement en primary Key
            builder.Property(p => p.Id)
                .HasColumnName("Id");
            builder.HasKey(p => p.Id);

            // Propriété Nom avec quelques contraintes
            builder.Property(p => p.Nom)
                .HasMaxLength(100)
                .IsRequired();

            // Relation One to Many explicit
            builder.HasOne(p => p.Referent)
                .WithMany()
                .HasPrincipalKey(p => p.Id)
                .HasForeignKey(p => p.ReferentId);

        }
    }
}
