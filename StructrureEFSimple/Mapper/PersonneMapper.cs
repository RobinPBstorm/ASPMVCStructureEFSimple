using StructrureEFSimple.Models;
using StructureEFSimple.DAL.Entities;

namespace StructrureEFSimple.Mapper
{
    public static class PersonneMapper
    {
        public static PersonneViewModel toViewModel(this Personne entity)
        {
            return new PersonneViewModel
            {
                Id = entity.Id,
                Nom = entity.Nom,
                Referent = entity.Referent is not null ? entity.Referent.toViewModel() : null
            };
        }
    }
}
