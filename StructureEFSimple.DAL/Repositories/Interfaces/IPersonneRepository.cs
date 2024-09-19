using StructureEFSimple.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureEFSimple.DAL.Repositories.Interfaces
{
    public interface IPersonneRepository: IRepository<int,Personne>
    {
    }
}
