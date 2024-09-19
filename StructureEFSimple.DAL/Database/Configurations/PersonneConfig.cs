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

            builder.Property(p => p.Nom)
                .HasMaxLength(100)
                .IsRequired();

            builder.HasOne(p => p.Referent)
                .WithOne();

        }
    }
}
