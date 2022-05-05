using Javacream.Util;
using Javacream.People;
using Javacream.BusinessObjects;
using Javacream.Music;
using Javacream.Books;

public static class Application{
    public static University CreateDefaultUniversity(){
        return new University("LMU", new Address(81371, "München", "Marienplatz"));
    }
    public static Company CreateDefaultCompany(){
        Company c = new Company("Javacream", new Address(81371, "München", "Karlsplatz"));
        c.AddDepartmentAddress("dep1", new Address(33333, "Berlin", "Karlsplatz"));
        c.AddDepartmentAddress("dep2", new Address(44444, "Hamburg", "Karlsplatz"));
    return c;
    }

    public static Person CreateDefaultPerson(){
        Person p = new Person("Sawitzki", "Rainer", 183, Gender.Male);
        p.address = new Address(81371, "München", "Marienplatz");
        return p;
    }
    public static Student CreateDefaultStudent(){
        Student s = new Student("Einstein", "Albert", 163, Gender.Male, CreateDefaultUniversity());
        s.address = new Address(30333, "Berlin", "Alexanderplatz");
        return s;
    }
    public static Worker CreateDefaultWorker(){
        Worker w = new Worker("Schufter", "Johanna", 163, Gender.Female, CreateDefaultCompany());
        w.address = new Address(70000, "Stutgart", "Alexanderplatz");
        return w;
    }

    public static void TestCompany(){
        Company c = CreateDefaultCompany();
        Console.WriteLine(c.MainAddress.City);
    }
    public static void TestUniversity(){
        University u = CreateDefaultUniversity();
        Console.WriteLine(u.Address.City);
    }

    public static void TestPeople(){
        Person p = Application.CreateDefaultPerson();
        Student s = Application.CreateDefaultStudent();
        Worker w = Application.CreateDefaultWorker();
        Console.WriteLine("Debug to check people!");
    }
    public static void TestAddressBook(){
        AddressBook addressBook = new AddressBook();
        Company c = CreateDefaultCompany();
        Person p = Application.CreateDefaultPerson();
        Student s = Application.CreateDefaultStudent();
        addressBook.AddAddressable(c);
        addressBook.AddAddressable(p);
        addressBook.AddAddressable(s);


    }

    public static void TestSound(){
        Guitar guitar1 = new Guitar("Fender 6 String");
        Guitar guitar2 = new Guitar("Rickenbacher");
        Bass bass = new Bass("Höfner");
        Drum drum = new Drum("Ludwig");
        Band band = new Band();
        band.AddSoundGenerator(guitar1);
        band.AddSoundGenerator(guitar2);
        band.AddSoundGenerator(bass);
        band.AddSoundGenerator(drum);
        band.AddSoundGenerator(CreateDefaultPerson());
        band.Play();        
    }

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
        Console.WriteLine(booksService.CreateBook(new Isbn(1,2,3,4), "Title1", 120, 29.99, true, empty).Info());
        Console.WriteLine(booksService.CreateBook(new Isbn(1,2,3,5), "Title2", 130, 19.99, true, school).Info());
        Isbn isbn3 = new Isbn(1,2,3,6);
        Console.WriteLine(booksService.CreateBook(isbn3, "Title3", 110, 9.99, true, specialist).Info());
        Console.WriteLine(booksService.FindBookByIsbn(isbn3).Info());



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