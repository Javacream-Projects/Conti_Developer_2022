using Javacream.People;
while(true){
Console.Write("enter a test (todo, pub, bs, b, s, c, u, p, a) or x for exit:");    
string test = Console.ReadLine();
switch (test){
    case "todo": {
        Application.TestToDoService();
        break;
    }
    case "pub": {
        Application.TestPublisher();
        break;
    }

    case "bs": {
        Application.TestBooksService();
        break;
    }
    case "b": {
        Application.TestBooks();
        break;
    }
    case "s": {
        Application.TestSound();
        break;
    }
    case "a": {
        Application.TestAddressBook();
        break;
    }
    case "c": {
        Application.TestCompany();
        break;
    }
    case "u": {
        Application.TestUniversity();
        break;
    }
    case "p": {
        Application.TestPeople();
        break;
    }
    case "x": {
        Environment.Exit(0);
        break;
    }

}
}