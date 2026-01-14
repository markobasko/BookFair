using BookFair.Model;
using BookFair.Service;
using System;
namespace BookFair
{
    public class Application
    {
        private readonly AddressService _addressService;
        private readonly BookService _bookService;
        private readonly AuthorService _authorService;
        private readonly VisitorService _visitorService;

        public Application()
        {
            _addressService = new AddressService();
            _bookService = new BookService();
            _authorService = new AuthorService();
            _visitorService = new VisitorService();
        }

        public void Run()
        {
            bool running = true;
            while (running)
            {
                ShowMenu();
                string choice = Console.ReadLine() ?? "";
                switch (choice)
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
                        //AddAddress();
                        break;
                    case "5":
                        //RemoveAddress();
                        break;
                    case "6":
                        //PrintAddresses();
                        break;
                    case "7":
                        AddAuthor();
                        break;
                    case "8":
                        RemoveAuthor();
                        break;
                    case "9":
                        PrintAuthor();
                        break;
                    case "10":
                        //AddVisitor();
                        break;
                    case "11":
                        //RemoveVisitor();
                        break;
                    case "12":
                        //PrintVisitors();
                        break;
                    case "13":
                        running = false;
                        break;
                    default:
                        break;
                }
            }

        }

        private void ShowMenu()
        {
            Console.WriteLine("\n --- BookFair ---");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Remove Book");
            Console.WriteLine("3. Print Books");
            Console.WriteLine("4. Add Address");
            Console.WriteLine("5. Remove Address");
            Console.WriteLine("6. Print Address");
            Console.WriteLine("7. Add Author");
            Console.WriteLine("8. Remove Author");
            Console.WriteLine("9. Print Author");
            Console.WriteLine("10. Add Visitor");
            Console.WriteLine("11. Remove Visitor");
            Console.WriteLine("12. Print Visitor");
            Console.WriteLine("13. Exit");
        }

        private void AddBook()
        {
            Console.WriteLine("Book ISBN: ");
            string ISBN = Console.ReadLine();
            Console.WriteLine("Book name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Book Genre: ");
            Genre genre = Enum.Parse<Genre>(Console.ReadLine());
            Console.WriteLine("Book Price: ");
            int Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Book Number of Pages: ");
            int NumberOfPages = Convert.ToInt32(Console.ReadLine());
            Book newbook = new Book(ISBN, name, genre, Price, NumberOfPages);
            _bookService.Add(newbook);
        }
        private void PrintBooks()
        {
            List<Book> books = _bookService.GetAll();
            foreach (Book book in books)
            {
                Console.WriteLine($"{book.Id} {book.Name} {book.ISBN} {book.Genre} price: {book.Price} number of pages: {book.NumberOfPages}");
            }
        }
        private void RemoveBook()
        {
            int id = Convert.ToInt32(Console.ReadLine());
            _bookService.Remove(id);
        }

        private void AddAuthor()
        {
            Console.WriteLine("Author FirstName: ");
            string FirstName = Console.ReadLine() ?? "";
            Console.WriteLine("Author LastName: ");
            string LastName = Console.ReadLine() ?? ""; 
            Console.WriteLine("Author DateOfBirth: ");
            DateTime DateOfBirth = DateTime.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("Author Address Id: ");
            Address Address = new Address() {Id=Convert.ToInt32(Console.ReadLine()) };
            Console.WriteLine("Author Phone Number: ");
            string PhoneNumber = Console.ReadLine() ?? "";
            Console.WriteLine("Author Email: ");
            string Email = Console.ReadLine() ?? "";
            Console.WriteLine("Author IdCardNumber: ");
            string IdCardNumber = Console.ReadLine() ?? "";
            Console.WriteLine("Author YearsOfExperience: ");
            int YearsOfExperience = Convert.ToInt32(Console.ReadLine());
            Author newauthor = new Author(FirstName, LastName, DateOfBirth, Address, PhoneNumber, Email, IdCardNumber, YearsOfExperience);
            _authorService.Add(newauthor);

        }
        private void PrintAuthor()
        {
            List<Author> authors = _authorService.GetAll();
            foreach (Author author in authors)
            {
                Console.WriteLine($"\nauthor Id: {author.Id} \nauthor FirstName: {author.FirstName} \nauthor LastName: {author.LastName} \nauthor DateOfBirth: {author.DateOfBirth} \nauthor Address: {author.Address} \nAuthor Phone Number: {author.PhoneNumber} \nAuthor Email: {author.Email} \nAuthor IdCardNumber: {author.IdCardNumber} \nAuthor YearsOfExperience: {author.YearsOfExperience}");
            }
        }
        private void RemoveAuthor()
        {
            int id = Convert.ToInt32(Console.ReadLine());
            _authorService.Remove(id);
        }
    }
}