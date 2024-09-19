using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StructureEFSimple.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureEFSimple.DAL.Database.Data
{
    public class DataSetPersonne: IEntityTypeConfiguration<Personne>
    {
        public void Configure(EntityTypeBuilder<Personne> builder)
        {
            builder.HasData(
                new Personne
                {
                    Id = 1,
                    Nom = "Thierry",
                    ReferentId = null
                },
                new Personne
                {
                    Id = 2,
                    Nom = "Marc",
                    ReferentId = 1
                }
                );
        }
    }
}
