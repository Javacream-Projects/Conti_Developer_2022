using Javacream.People;
using Javacream.Util;
using System; //System-Namespace wird automatisch immer benutzt

Person p = new Person("Sawitzki", "Rainer", 183, Gender.Male);
Student s = new Student("Einstein", "Albert", 176, Gender.Male, "LMU");
Worker w = new Worker("Schufter", "Hannah", 176, Gender.Female, "Integrata");
Person ps = new Student("Bohr", "Niels", 176, Gender.Male, "LMU");
Person pw = new Worker("Schneider", "Emil", 176, Gender.Female, "Integrata");



Console.WriteLine(p.SayHello());
Console.WriteLine(s.SayHello());
Console.WriteLine(w.SayHello());
Console.WriteLine(ps.SayHello());
Console.WriteLine(pw.SayHello());
