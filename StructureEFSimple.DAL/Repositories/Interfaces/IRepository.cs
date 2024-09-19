using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureEFSimple.DAL.Repositories.Interfaces
{
    public interface IRepository<Key,T>
    {
        public List<T> GetAll();
        public T? GetOneById(Key key);
        public T Create(T entity);
        public T Update(T entity);
        public void Delete(T entity);
    }
}
