using Javacream.People;
using Javacream.Util;
using System; //System-Namespace wird automatisch immer benutzt

Person p = new Person("Sawitzki", "Rainer", 183, Gender.Male);
Student s = new Student("Einstein", "Albert", 176, Gender.Male, "LMU");
Worker w = new Worker("Schufter", "Hannah", 176, Gender.Female, "Integrata");
s.Study();
w.Work();

s.Marry(w); //Geht!, aber die Signatur ist doch  Marry(Person partner)!
//Aber: Ein Student/Worker ist eine Person!
Person ps = s;
Person pw = w;
//Student sw = w;//Das geht nicht, ein Worker ist kein Student!

//Natürlich ist ein Student/Worker/Person auch ein Object!
Object os = s;
Object ow = w;
Object op = p;

/*

WICHTIG: Achten Sie auf den Code-Assist und den Debugger!

- Welche Methoden und Attribute werden z.B. für s, ps, os angezeigt
- Was ist im Debugger zu sehen für z.B. s, ps, os 

*/

Console.WriteLine(s == ps);
Console.WriteLine(s == os);

//Person po = os;//Compiler-Fehler, ein Objekt ist nicht garantiert eine Person
Person po = (Person)os;
Student so = (Student)os;

//Worker wo = (Worker)os;  //InvalidCastException
//Address a = (Address)os;//InvalidCastException
//Worker ws = (Worker)s; Compiler-Fehler, dieser Cast ist schon auf Grund der Vererbungshierarchie nicht möglich!
//string str = (string)s;Compiler-Fehler, dieser Cast ist schon auf Grund der Vererbungshierarchie nicht möglich!

Console.WriteLine(w.GetType());
Console.WriteLine(s.GetType());
Console.WriteLine(ps.GetType());
Console.WriteLine(os.GetType());

//Type type = os.GetType();
//Console.WriteLine(type.BaseType.BaseType.BaseType);
TypeHelper.PrintTypes(w);
