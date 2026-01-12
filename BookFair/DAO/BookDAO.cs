using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookFair.Model;
using BookFair.Storage;

namespace BookFair.DAO
{
    public class BookDAO : IDAO<Book>
    {
        private readonly List<Book> _books;
        private readonly Storage<Book> _storage;
        public BookDAO()
        {
            _storage = new Storage<Book>("books.txt");
            _books = _storage.Load();
        }
        private int GenrateID()
        {
            if (_books.Count == 0)
                return 0;
            return _books.Max(b => b.Id) + 1;
        }
        public Book GetById(int id)
        {
            var book = _books.FirstOrDefault(a => a.Id == id);
            return book == null ? throw new KeyNotFoundException($"Book with ID {id} not found.") : book;
        }
        public void Add(Book item)
        {
            item.Id = GenrateID();
            _books.Add(item);
            _storage.Save(_books);
        }
        public void Remove(int id)
        {
            Book book = GetById(id);
            _books.Remove(book);
            _storage.Save(_books);
        }
        public void Update(Book item)
        {
            var index = _books.FindIndex(b => b.Id == item.Id);
            if (index == -1)
            {
                _books[index] = item;
                _storage.Save(_books);
            }
            else
            {
                throw new KeyNotFoundException($"Book with ID {item.Id} not found.");
            }
        }
        public List<Book> GetAll()
        {
            return _books;
        }
 
    }
}
