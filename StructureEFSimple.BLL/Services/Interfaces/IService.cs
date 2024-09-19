namespace StructrureEFSimple.BLL.Services.Interfaces
{
    public interface IService<Key, T>
    {
        public List<T> GetAll();
        public T GetOneById(Key key);
        public T Create(T entity);
        public bool Update(T entity);
        public bool Delete(T entity);
    }
}
