using Javacream.People;
using Javacream.Util;
using System; //System-Namespace wird automatisch immer benutzt
Person sawitzki = new Person("Sawitzki", "Rainer", 183, Gender.Male);
Person mustermann = new Person("Mustermann", "Hannah", 188, Gender.Female);Console.WriteLine(Person.PeopleCounter);
Person meier = new Person("Meier", "Johann", 168, Gender.Diverse);

Address a1 = new Address(81371, "München", "Marienplatz");
Address a2 = new Address(30333, "Berlin", "Alexanderplatz");

sawitzki.address = a1;
mustermann.address = a1;
meier.address=a2;