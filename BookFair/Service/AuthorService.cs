using BookFair.DAO;
using BookFair.Model;

namespace BookFair.Service
{
    public class AuthorService
    {
        private readonly AuthorDAO _authorDAO;
        public AuthorService()
        {
            _authorDAO = new AuthorDAO();
        }
        public List<Author> GetAll()
        {
            List<Author> authors = _authorDAO.GetAll();
            return authors;
        }
        public Author GetById(int id)
        {
            return _authorDAO.GetById(id);
        }
        public void Add(Author author)
        {
            if (author == null)
                throw new ArgumentNullException(nameof(author), "Author cannot be null.");
            _authorDAO.Add(author);
        }
        public void Remove(int authorID)
        {
            _authorDAO.Remove(authorID);
        }
        public void Update(Author author)
        {
            if (author == null)
                throw new ArgumentNullException(nameof(author), "Author cannot be null.");
            _authorDAO.Update(author);
        }
    }
}

