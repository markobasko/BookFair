using BookFair.DAO;
using BookFair.Model;

namespace BookFair.Service
{
    public class BookService
    {
        private readonly BookDAO _bookDAO;
        public BookService()
        {
            _bookDAO = new BookDAO();
        }
        public List<Book> GetAll()
        {
            List<Book> books = _bookDAO.GetAll();
            return books;
        }
        public Book GetById(int id)
        {
            return _bookDAO.GetById(id);
        }
        public void Add(Book book)
        {
            if (book == null)
                throw new ArgumentNullException(nameof(book), "Book cannot be null.");
            _bookDAO.Add(book);
        }
        public void Remove(int bookId)
        {
            _bookDAO.Remove(bookId);
        }
        public void Update(Book book)
        {
            if (book == null)
                throw new ArgumentNullException(nameof(book), "Book cannot be null.");
            _bookDAO.Update(book);
        }
    }
}
