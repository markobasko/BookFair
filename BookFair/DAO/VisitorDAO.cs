using BookFair.Model;
using BookFair.Storage;

namespace BookFair.DAO
{
    public class VisitorDAO : IDAO<Visitor>
    {
        private readonly List<Visitor> _visitors;
        private readonly Storage<Visitor> _storage;
        public VisitorDAO()
        {
            _storage = new Storage<Visitor>("visitors.txt");
            _visitors = _storage.Load();
        }

        private int GenerateId()
        {
            if (_visitors.Count == 0)
                return 0;
            return _visitors.Max(v => v.Id) + 1;
        }

        public Visitor GetById(int id)
        {
            var visitor = _visitors.FirstOrDefault(v => v.Id == id);
            return visitor == null ? throw new KeyNotFoundException($"Visitor with ID {id} not found.") : visitor;
        }

        public void Add(Visitor item)
        {
            item.Id = GenerateId();
            _visitors.Add(item);
            _storage.Save(_visitors);
        }

        public void Remove(int id)
        {
            Visitor visitor = GetById(id);
            _visitors.Remove(visitor);
            _storage.Save(_visitors);
        }

        public void Update(Visitor item)
        {
            var index = _visitors.FindIndex(v => v.Id == item.Id);
            if (index != -1)
            {
                _visitors[index] = item;
                _storage.Save(_visitors);
            }
            else
            {
                throw new KeyNotFoundException($"Visitor with ID {item.Id} not found.");
            }
        }

        public List<Visitor> GetAll()
        {
            return _visitors;
        }

 
    }
}
