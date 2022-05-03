using People;
using System; //System-Namespace wird automatisch immer benutzt
//Person.PeopleCounter = -5; //Compiler-Fehler, setter für PeopleCounter ist private
Person sawitzki = new Person("Sawitzki", "Rainer", 183, 'm');
Console.WriteLine(Person.PeopleCounter);
Person mustermann = new Person("Mustermann", "Hannah", 188, 'f');
Console.WriteLine(Person.PeopleCounter);
Person meier = new Person("Meier", "Johann", 168, 'd');
Console.WriteLine(Person.PeopleCounter);


Console.WriteLine(sawitzki.Marry(null));
Console.WriteLine(sawitzki.Marry(sawitzki));
Console.WriteLine(sawitzki.Marry(mustermann));
Console.WriteLine(meier.Marry(mustermann));
Console.WriteLine(mustermann.Marry(meier));
Console.WriteLine("finish marriage");

Console.WriteLine(meier.Divorce());
Console.WriteLine(sawitzki.Divorce());
Console.WriteLine(mustermann.Marry(meier));

Console.WriteLine("finish divorce");

meier.Lastname = "Schneider";
Console.WriteLine(meier.Lastname);


