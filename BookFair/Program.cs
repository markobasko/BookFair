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
            bool running = true; 
            while (running)
            {
                ShowMenu();
                string choice = Console.ReadLine() ?? "";
                switch(choice)
                {
                    case "1":
                        AddBook();
                        break;
                    case "2":
                        RemoveBook();
                        break;
                    case "3":
                        PrintBooks();
                        break;
                    case "4":
                        AddAddress();
                        break;
                    case "5":
                        RemoveAddress();
                        break;
                    case "6":
                        PrintAddresses();
                        break;
                    case "7":
                        AddAutor();
                        break;
                    case "8":
                        RemoveAuthor();
                        break;
                    case "9":
                        PrintAuthors();
                        break;
                    case "10":
                        AddVisitor();
                        break;
                    case "11":
                        RemoveVisitor();
                        break;
                    case "12":
                        PrintVisitors();
                        break;
                }
            }

        }
    }
}