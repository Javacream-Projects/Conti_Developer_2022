using Javacream.People;
while(true){
Console.Write("enter a test (c, u, p) or x for exit:");    
string test = Console.ReadLine();
switch (test){
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