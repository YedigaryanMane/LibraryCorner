namespace LibraryCorner.Repositories
{
    public interface IRepository<T,TRequest>
    {
        void Add(T t);
        void Delete(T t);
        void Update(T t);
        T Get(int id);
        IEnumerable<T> GetAll();
        T Find(TRequest request);
    }
}
