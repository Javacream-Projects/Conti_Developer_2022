while(true){
Console.Write("enter a test (pub, bs, b) or x for exit:");    
string? test = Console.ReadLine();
switch (test){
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
    case "x": {
        Environment.Exit(0);
        break;
    }
}
}