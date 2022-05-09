using Javacream.Util;
using Javacream.Books;
public static class Application{
public static Book CreateDefaultBook(){
    return new Book(new Isbn(1,2,3,4), "Title 1", 100, 19.99, true);
}
public static SchoolBook CreateDefaultSchoolBook(){
    return new SchoolBook(new Isbn(1,2,3,5), "Title 2", 120, 29.99, true, 10, "physics");
}
public static SpecialistBook CreateDefaultSpecialistBook(){
    return new SpecialistBook(new Isbn(1,2,3,6), "Title 3", 200, 9.99, true, "gardening");
}
    public static void TestBooks(){
        Book book = CreateDefaultBook();
        SchoolBook schoolBook = CreateDefaultSchoolBook();
        SpecialistBook specialistBook = CreateDefaultSpecialistBook();
        Console.WriteLine(book.Info());
        Console.WriteLine(schoolBook.Info());
        Console.WriteLine(specialistBook.Info());

    }
    public static void TestBooksService(){
        BooksService booksService = new BooksService();
        Dictionary<string, Object> empty= new Dictionary<string, Object>();
        Dictionary<string, Object> school = new Dictionary<string, Object>();
        school.Add("year", 10);
        school.Add("subject", "sports");
        Dictionary<string, Object> specialist = new Dictionary<string, Object>();
        specialist.Add("topic", "gardening");
        Console.WriteLine(booksService.CreateBook(new Isbn(1,2,3,4), "fTitle1", 120, 29.99, true, empty).Info());
        Console.WriteLine(booksService.CreateBook(new Isbn(1,2,3,5), "kTitle2", 130, 19.99, true, school).Info());
        Console.WriteLine(booksService.CreateBook(new Isbn(1,2,3,6), "aTitle3", 110, 9.99, true, specialist).Info());
        Console.WriteLine(booksService.FindBookByIsbn(new Isbn(1,2,3,6)).Info());
        //Console.WriteLine(booksService.FindBooksByTitle("Title2"));
        //Console.WriteLine(booksService.FindBooksByPriceRange(5,25));
        //booksService.FindBooksByTitle("Title2").ForEach(book => Console.WriteLine(book));
        //booksService.FindBooksByPriceRange(5,25).ForEach(book => Console.WriteLine(book));
        //booksService.FindBooksByTitle("Title2").ForEach(Console.WriteLine);
        List<Book> result = booksService.FindBooksByPriceRange(5,25);
        result.Sort();
        result.ForEach(Console.WriteLine);
        result.Sort((b1, b2) => b1.Price.CompareTo(b2.Price));
        result.ForEach(Console.WriteLine);

    }

    public static void TestPublisher(){
        Publisher springer = new Publisher("Springer");
        Console.WriteLine(springer.Name);
        Book b1 = CreateDefaultBook();
        Book b2 = CreateDefaultSchoolBook();
        Book b3 = CreateDefaultSpecialistBook();        
        springer.AddBook(b1);
        springer.AddBook(b2);
        springer.AddBook(b3);
        Console.WriteLine("After adding 3 books:");
        foreach (Book b in springer.GetAllBooks()){
            Console.WriteLine(b.Info());
        }
        springer.RemoveBook(b2);
        Console.WriteLine("After removing book b2:");
        foreach (Book b in springer.GetAllBooks()){
            Console.WriteLine(b.Info());
        }
        springer.ClearBooks();
        Console.WriteLine("After clear:");

        foreach (Book b in springer.GetAllBooks()){
            Console.WriteLine(b.Info());
        }




    }

}