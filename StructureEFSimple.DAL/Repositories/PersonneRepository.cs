using Microsoft.EntityFrameworkCore;
using StructureEFSimple.DAL.Database;
using StructureEFSimple.DAL.Entities;
using StructureEFSimple.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureEFSimple.DAL.Repositories
{
    public class PersonneRepository : IPersonneRepository
    {
        private readonly PersonneContext _context;
        public PersonneRepository(PersonneContext context) 
        {
            _context = context;
        }

        public Personne Create(Personne entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Personne entity)
        {
            throw new NotImplementedException();
        }

        public List<Personne> GetAll()
        {
            return _context.Personnes
                .ToList();
        }

        public Personne? GetOneById(int key)
        {
            return _context.Personnes
                .Include(p => p.Referent)
                .FirstOrDefault(p => p.Id == key);
		}

        public bool Update(Personne entity)
        {
            throw new NotImplementedException();
        }
    }
}
