string PlanetFromPosition(int position)
{
    string planetName;
        switch(position)
        {
            case 1:
                {
                    planetName = "Mercury";
                    break;
                }
            case 2:
                {
                    planetName = "Venus";
                    break;
                }
            case 3:
                {
                    planetName = "Earth";
                    break;
                }
            case 4:
                {
                    planetName = "Mars";
                    break;
                }
            case 5:
                {
                    planetName = "Jupiter";
                    break;
                }
            case 6:
                {
                    planetName = "Saturn";
                    break;
                }
            case 7:
                {
                    planetName = "Uranus";
                    break; 
                }
            case 8:
                {
                    planetName = "Neptune";
                    break;
                }
            case 9:
                {
                    planetName = "Pluto";
                    break;
                }
            default:
                {   
                    Exception e = new Exception("unknown");//y"unknown"y; y...y als "Exception-Literal
                    throw e;
                }
        }

    return planetName;
}

void Application()
{
    foreach (string planetPositionAsString in args)
    {
        try
        {
            int planetPosition = Convert.ToInt32(planetPositionAsString);
            string planetName = PlanetFromPosition(planetPosition);
            Console.WriteLine("Planet with number {0} is {1}", planetPosition, planetName);
        }
        catch(Exception e)
        {
            Console.WriteLine("Invalid input: {0}", planetPositionAsString);
            Console.WriteLine(e.Message);
        }
    }
}

Application();