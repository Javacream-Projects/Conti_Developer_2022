using Javacream.People;
while(true){
Console.Write("enter a test (s, c, u, p, a) or x for exit:");    
string test = Console.ReadLine();
switch (test){
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