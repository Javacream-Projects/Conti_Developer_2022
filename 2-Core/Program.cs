int planet = Convert.ToInt32(Console.ReadLine());
if (planet > 0 && planet <= 9)
{

    string output = "Planet is ";
    switch(planet)
    {
        case 1:
            {
                break;
            }
        case 2:
            {
                output += "Venus";
                break;
            }
        case 3:
            {
                output += "Earth";
                break;
            }
        case 4:
            {
                output += "Mars";
                break;
            }
        case 5:
            {
                output += "Jupiter";
                break;
            }
        case 6:
            {
                output += "Saturn";
                break;
            }
        case 7:
            {
                output += "Uranus";
                break;
            }
        case 8:
            {
                output += "Neptune";
                break;
            }
        case 9:
            {
                output += "Pluto";
                break;
            }
    }
    Console.WriteLine(output);
}
else{
    Console.WriteLine("Planet is unknown");
}