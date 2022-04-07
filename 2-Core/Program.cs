//if - else
bool state = false;

string output = "state was true";

if (state == false)
{
    Console.WriteLine(output);
}
else
{
    Console.WriteLine("state was false");

}

int i1 = 4;
int i2 = 42;

bool result = i1 < i2; 
if (result)
{
    Console.WriteLine(output);
}


if (i1 < i2)
{
    Console.WriteLine("state was true");
}
//Korrekt, aber ungebräuchlich
if (i1 < i2)
    Console.WriteLine("state was true");


//switch-case

int planet = 1;

switch(planet)
{
    case 1:
        {
            Console.WriteLine("Planet is Mercury");
            break;
        }
    case 2:
        {
            Console.WriteLine("Planet is Venus");
            break;
        }
    default:
    {
            Console.WriteLine("Planet is unknown");
            break;

    }
}
