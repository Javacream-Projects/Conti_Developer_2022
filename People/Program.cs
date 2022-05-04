using Javacream.People;
using Javacream.Util;
using System; //System-Namespace wird automatisch immer benutzt

Person p = new Person("Sawitzki", "Rainer", 183, Gender.Male);
Student s = new Student("Einstein", "Albert", 176, Gender.Male, "LMU");
Worker w = new Worker("Schufter", "Hannah", 176, Gender.Female, "Integrata");

//PrintOut(p);
//PrintOut(s);
//PrintOut(w);

Person[] people = {p, s, w};
foreach(Person person in people){
    Console.WriteLine(person.SayHello());
}
void PrintOut(Person person){
    Console.WriteLine(person.SayHello());
}