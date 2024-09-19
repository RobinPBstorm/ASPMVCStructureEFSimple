using StructrureEFSimple.BLL.Services.Interfaces;
using StructureEFSimple.BLL.Models.Exceptions;
using StructureEFSimple.DAL.Entities;
using StructureEFSimple.DAL.Repositories.Interfaces;

namespace StructrureEFSimple.BLL.Services
{
    public class PersonneService : IPersonneService
    {
        private readonly IPersonneRepository _repo;
        public PersonneService(IPersonneRepository repo) 
        {
            _repo = repo;
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
            return _repo.GetAll();
        }

        public Personne GetOneById(int key)
        {
            Personne? personne = _repo.GetOneById(key);

            if (personne is null)
            {
                throw new PersonneNotFoundException($"Aucune personne n'a été trouvé avec l'id {key}");
            }

            return personne;
        }

        public bool Update(Personne entity)
        {
            throw new NotImplementedException();
        }
    }
}
