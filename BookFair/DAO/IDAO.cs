namespace BookFair.DAO
{
    public interface IDAO<T>
    {
        T GetById(int id);
        void Add(T item);
        void Remove(int id);
        void Update(T item);
        List<T> GetAll();
    }
}