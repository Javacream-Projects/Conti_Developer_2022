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
    return new Book("ISBN-1", "Title 1", 100, 19.99, true);
}
public static SchoolBook CreateDefaultSchoolBook(){
    return new SchoolBook("ISBN-1", "Title 2", 120, 29.99, true, 10, "physics");
}
public static SpecialistBook CreateDefaultSpecialistBook(){
    return new SpecialistBook("ISBN-1", "Title 3", 200, 9.99, true, "gardening");
}
    public static void TestBooks(){
        Book book = CreateDefaultBook();
        SchoolBook schoolBook = CreateDefaultSchoolBook();
        SpecialistBook specialistBook = CreateDefaultSpecialistBook();
        Console.WriteLine(book.info());
        Console.WriteLine(schoolBook.info());
        Console.WriteLine(specialistBook.info());

    }
}