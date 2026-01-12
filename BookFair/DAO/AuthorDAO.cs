using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookFair.Model;
using BookFair.Storage;

namespace BookFair.DAO
{
    public class AuthorDAO: IDAO<Author>
    {
        private readonly List<Author> _authors;
        private readonly Storage<Author> _storage;
        public AuthorDAO()
        {
            _storage = new Storage<Author>("authors.txt");
            _authors = _storage.Load();
        }
        private int GenrateID()
        {
            if(_authors.Count == 0)
                return 0;
            return _authors.Max(a => a.Id)+1;
        }
        public Author GetById(int id)
        {
            var author = _authors.FirstOrDefault(a => a.Id == id);
            return author == null ? throw new KeyNotFoundException($"Author with ID {id} not found.") : author;
        }
        public void Add(Author item)
        {
            item.Id = GenrateID();
            _authors.Add(item);
            _storage.Save(_authors);
        }
        public void Remove(int id)
        {
            Author author = GetById(id);
            _authors.Remove(author);
            _storage.Save(_authors);
        }
        public void Update(Author item) {
            var index = _authors.FindIndex(a => a.Id == item.Id);
            if(index == -1)
            {
                _authors[index] = item;
                _storage.Save(_authors);
            }
            else
            {
                throw new KeyNotFoundException($"Author with ID {item.Id} not found.");
            }
        }
        public List<Author> GetAll()
        {  
            return _authors; 
        }
     
    }   
}
