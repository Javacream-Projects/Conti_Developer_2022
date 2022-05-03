using People;
Person sawitzki = new Person("Sawitzki", "Rainer", 183, 'm');
Person mustermann = new Person("Mustermann", "Hannah", 188, 'f');
Person meier = new Person("Meier", "Johann", 168, 'd');


Console.WriteLine(sawitzki.marry(null));
Console.WriteLine(sawitzki.marry(sawitzki));
Console.WriteLine(sawitzki.marry(mustermann));
Console.WriteLine(meier.marry(mustermann));
Console.WriteLine(mustermann.marry(meier));
Console.WriteLine("finish marriage");

Console.WriteLine(meier.divorce());
Console.WriteLine(sawitzki.divorce());
Console.WriteLine(mustermann.marry(meier));

Console.WriteLine("finish divorce");

