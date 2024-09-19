using Microsoft.EntityFrameworkCore;
using StructureEFSimple.DAL.Database.Configurations;
using StructureEFSimple.DAL.Database.Data;
using StructureEFSimple.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureEFSimple.DAL.Database
{
    public class PersonneContext : DbContext
    {
        public DbSet<Personne> Personnes { get; set; }

        public PersonneContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonneConfig());

            modelBuilder.ApplyConfiguration(new DataSetPersonne());

        }
    }
}
