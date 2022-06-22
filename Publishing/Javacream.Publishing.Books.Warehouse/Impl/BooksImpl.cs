using Javacream.IsbnGenerator.API;
using Javacream.Store.API;
using Javacream.Books.API;
namespace Javacream.Books.Impl
{

    public class BooksService : IBooksService
    {
        public BooksService(IIsbnService isbnService, IStoreService storeService){
            this._isbnService = isbnService;
            this._storeService = storeService; 
        }
        private IIsbnService _isbnService;
        private IStoreService _storeService;
        private Dictionary<Isbn, Book> _books = new Dictionary<Isbn, Book>();
        public Isbn CreateBook(string title, int pages, double price, Dictionary<string, Object> options)
        {
            bool available = false;
            Isbn isbn = this._isbnService.Next();
            Book newBook;
            try
            {
                string? topic = options["topic"].ToString();
                newBook = new SpecialistBook(isbn, title, pages, price, available, topic!);
            }
            catch (Exception)
            {
                try
                {
                    string? subject = options["subject"].ToString();
                    int year = (int)options["year"];
                    newBook = new SchoolBook(isbn, title, pages, price, available, year, subject!);
                }
                catch (Exception)
                {
                    newBook = new Book(isbn, title, pages, price, available);
                }
            }
            this._books.Add(isbn, newBook);
            return isbn;
        }

        public Book FindBookByIsbn(Isbn isbn)
        {
            Book book = this._books[isbn];
            this.SetAvailability(book);
            return book;
        }
        public void DeleteBookByIsbn(Isbn isbn)
        {
            this._books.Remove(isbn);
        }

        public List<Book> FindBooksByTitle(string title)
        {
            var bookList = this._books.Values.ToList();
            return bookList.FindAll(book => book.Title.Equals(title)).ConvertAll(book => SetAvailability(book));
        }
        public List<Book> FindBooksByPriceRange(double minPrice, double maxPrice)
        {
            var bookList = this._books.Values.ToList();
            return bookList.FindAll(book => book.Price > minPrice && book.Price < maxPrice).ConvertAll(this.SetAvailability);
        }

        private Book SetAvailability(Book book)
        {
            int stockForIsbn = this._storeService.GetStock("books", book.Isbn);
            if (stockForIsbn > 0)
            {
                book.Available = true;
            }
            else
            {
                book.Available = false;
            }
            return book;
        }
    }

}