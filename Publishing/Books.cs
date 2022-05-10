using Javacream.IsbnGenerator;

namespace Javacream.Books
{

    public class Publisher
    {
        public string Name { get; }
        private List<Book> _books;

        public Publisher(string name)
        {
            this.Name = name;
            _books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            this._books.Add(book);
        }
        public void RemoveBook(Book book)
        {
            this._books.Remove(book);

        }
        public void ClearBooks()
        {
            this._books.Clear();
        }
        public List<Book> GetAllBooks()
        {
            return this._books;
        }

    }
    public class BooksService
    {
        private IsbnService _isbnService = new IsbnService();
        private Dictionary<Isbn, Book> _books = new Dictionary<Isbn, Book>();
        public Book CreateBook(string title, int pages, double price, bool available, Dictionary<string, Object> options)
        {
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
            return newBook;
        }

        public Book FindBookByIsbn(Isbn isbn)
        {
            return this._books[isbn];
        }
        public void DeleteBookByIsbn(Isbn isbn)
        {
            this._books.Remove(isbn);
        }

        public List<Book> FindBooksByTitle(string title){
            var bookList = this._books.Values.ToList();
            return bookList.FindAll(book => book.Title.Equals(title));
        }
        public List<Book> FindBooksByPriceRange(double minPrice, double maxPrice){
            var bookList = this._books.Values.ToList();
            return bookList.FindAll(book => book.Price > minPrice && book.Price < maxPrice);
        }
    }
    public class Book : Object, IComparable<Book>
    {

        public int CompareTo(Book? book){
            if (book != null){
                return this.Title.CompareTo(book.Title);
            }else{
                throw new Exception ("null cannot be compared");
            }
        }
        public Isbn Isbn { get; }
        private string? _title;
        public string Title
        {
            get
            {
                return _title!;
            }
            private set
            {
                if (value.Length >= 2)
                {
                    this._title = value;
                }
                else
                {
                    throw new Exception("invalid title: " + value);
                }
            }
        }
        private int _pages;
        public int Pages
        {
            get
            {
                return _pages;
            }
            set
            {
                if (value > 0)
                {
                    this._pages = value;
                }
                else
                {
                    throw new Exception("invalid pages: " + value);
                }
            }
        }

        public bool Available { get; set; }

        private double _price;

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value >= 0)
                {
                    this._price = value;
                }
                else
                {
                    throw new Exception("invalid price: " + value);
                }

            }
        }

        public Book(Isbn isbn, string title, int pages, double price, bool available)
        {
            this.Isbn = isbn;
            this.Title = title;
            this.Pages = pages;
            this.Price = price;
            this.Available = available;
        }

        public virtual string Info()
        {
            return "Book: isbn=" + Isbn.ToString() + ", title=" + Title + ", pages=" + Pages + ", price=" + Price + ", available=" + Available;
        }

        public override string ToString()
        {
            return Info();
        }
    }

    public class SchoolBook : Book
    {
        public int Year { get; }
        public string Subject { get; }

        public SchoolBook(Isbn isbn, string title, int pages, double price, bool available, int year, string subject) : base(isbn, title, pages, price, available)
        {
            this.Year = year;
            this.Subject = subject;
        }
        public override string Info()
        {
            return base.Info() + ", year=" + Year + ", subject=" + Subject;
        }

    }

    public class SpecialistBook : Book
    {
        public string Topic { get; }

        public SpecialistBook(Isbn isbn, string title, int pages, double price, bool available, string topic) : base(isbn, title, pages, price, available)
        {
            this.Topic = topic;
        }
        public override string Info()
        {
            return base.Info() + ", topic=" + Topic;
        }

    }

}