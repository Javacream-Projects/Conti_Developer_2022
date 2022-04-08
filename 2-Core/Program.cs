//Array, eine Liste von Einträgen

string name = "Hugo";
string[] names = {"Hugo", "Emil", "Fritz"};

Console.WriteLine(name.Length);
Console.WriteLine(names.Length);
Console.WriteLine(names[0]);//Konzeptuell: names.0
Console.WriteLine(names[0].Length);//Konzeptuell: names.0.Length
//Ausführlicher
string element0 = names[0];
int element0Length = element0.Length;
Console.WriteLine(element0Length);

//Iteration über ein Array
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}

foreach (string nameInArray in names)
{
    Console.WriteLine(nameInArray);
}

