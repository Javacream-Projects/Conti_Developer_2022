//for-Loop

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

for (int i = 42; i <= 50; i+=2)
{
    Console.WriteLine(i);
}


/* Möglich, aber in der Praxis nicht gebräuchlich:

int counter = 0;
for (; counter < 5; counter++)
{
    int j = 2 * counter;
    Console.WriteLine(j);
}
Console.WriteLine(counter);

int counter2 = 0;
for (; counter2 < 5; )
{
    int j = 2 * counter2;
    Console.WriteLine(j);
    counter2++;
}
Console.WriteLine(counter);

int counter3 = 0;
bool condition = true;
for (; condition; )
{
    int j = 2 * counter3;
    Console.WriteLine(j);
    counter2++;
    if (counter3 == 5)
    {
        condition = false;
    }
}
Console.WriteLine(counter);
*/
