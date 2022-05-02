using People;
Person sawitzki = new Person("Sawitzki", "Rainer", 183, 'm');
Person mustermann = new Person("Mustermann", "Hannah", 188, 'f');

//Console.WriteLine(sawitzki.SayHello(sawitzki));
//Console.WriteLine(mustermann.SayHello(mustermann));
//Console.WriteLine(mustermann.SayHello(sawitzki));
Console.WriteLine(sawitzki.SayHello());
Console.WriteLine(mustermann.SayHello());