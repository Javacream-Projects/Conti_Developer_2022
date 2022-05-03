using People;
using System; //System-Namespace wird automatisch immer benutzt
//Person.PeopleCounter = -5; //Compiler-Fehler, setter für PeopleCounter ist private
Person sawitzki = new Person("Sawitzki", "Rainer", 183, Gender.Male);
Console.WriteLine(Person.PeopleCounter);
Person mustermann = new Person("Mustermann", "Hannah", 188, Gender.Female);
Console.WriteLine(Person.PeopleCounter);
Person meier = new Person("Meier", "Johann", 168, Gender.Diverse);
Console.WriteLine(Person.PeopleCounter);


try{
    sawitzki.Marry(null);
}
catch(Exception e){
    Console.WriteLine(e.Message);
}
try{
    sawitzki.Marry(sawitzki);
}
catch(Exception e){
    Console.WriteLine(e.Message);
}
sawitzki.Marry(mustermann);
try{

    meier.Marry(mustermann);
}
catch(Exception e){
    Console.WriteLine(e.Message);
}
try{
    mustermann.Marry(meier);
}
catch(Exception e){
    Console.WriteLine(e.Message);
}
Console.WriteLine("finish marriage");

try{
    meier.Divorce();
}
catch(Exception e){
    Console.WriteLine(e.Message);
}
sawitzki.Divorce();
mustermann.Marry(meier);

Console.WriteLine("finish divorce");

meier.Lastname = "";
Console.WriteLine(meier.Lastname);


