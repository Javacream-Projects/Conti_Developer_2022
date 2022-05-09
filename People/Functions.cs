using Javacream.Books;
public class FunctionsDemo
{
    public void doClassic()
    {
        //Type <name> = Literal
        string message = "Hello World";
        int number = 9;
        //Der new-Operator erzeugt Objekte und gibt die Referenz zurück
        Book b = new Book(new Isbn(1, 2, 3, 4), "title", 200, 19.99, false);
        Console.WriteLine(message + number);
    }

    public void doTypeInference()
    {
        //var <name> = Literal
        var message = "Hello World";
        var number = 9;
        //Der new-Operator erzeugt Objekte und gibt die Referenz zurück
        var b = new Book(new Isbn(1, 2, 3, 4), "title", 200, 19.99, false);
        Book b2 = new(new(1, 2, 3, 4), "title", 200, 19.99, false);

        //var isbn = new (1,2,3,4); so dann doch nicht...
        Console.WriteLine(message + number);
    }
    public Object introduceFunctionObjects()
    {
        //var <name> = Literal
        var message = "Hello World";
        //var <name> = Literal
        // (...) => {} ist nichts anderes als ein Funktions-Literal, Lambda-Ausdruck, Lambda-Funktion
        //Was ist der Typ von check? -> "Etwas, das aus einem Objekt einen bool macht"
        var check = (Object o) => { return true; };
        Func<Object, bool> check2 = check;
        return message;
    }

    public void FilterListDemo(){
        List<string>  names = new List<string>();
        names.Add("Hugo");
        names.Add("Emil");
        names.Add("Fritz");
        names.Add("Eduardo");

        //Problem: Erzeuge Trefferliste
        //1) Klassisches Loop
        List<string> result = new List<string>();
        foreach(string name in names){
            if (name.StartsWith("E")){
                result.Add(name);
            }

        }

        //2) Benutzung einer Predicate-Funktion string => bool
        List<string> result2 = names.FindAll((string name) => {return name.StartsWith("E");});
        //3) Benutzung einer kompakten Predicate-Funktion string => bool, Klammer und Typisierung der Parameter optional, optionaler Block mit implitem Return
        var result3 = names.FindAll(name => name.StartsWith("E"));
    }


}
class InnerClass
{
    public bool check(Object o)
    {
        return true;

    }
}

