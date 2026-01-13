using BookFair.Model;
using BookFair.Service;
using System;
namespace BookFair
{
    public class Program 
    {
        private readonly AddressService _addressService;
        private readonly BookService _bookService;
        private readonly AuthorService _authorService;
        private readonly VisitorService _visitorService;

        public Program()
        {
            _addressService = new AddressService();
            _bookService = new BookService();
            _authorService = new AuthorService();
            _visitorService = new VisitorService();
        }

        public static void Main(string[] args)
        {
            Application app = new Application();
            app.Run();

        }

      
      
    }
}