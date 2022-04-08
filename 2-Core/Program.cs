string[] PlanetsFromPositions(int[] positions)
{
    string[] planetNames = {};
    foreach (int position in positions)
    {
        string planetName = "";
        switch (position)
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
        }
        int lastLength = planetNames.Length;
        Array.Resize(ref planetNames, lastLength + 1);
        planetNames[lastLength] = planetName;
    }
    return planetNames;
}

    void Application()
    {
        Console.WriteLine("start planet name search...");
        int[] planetPositions = {};
        foreach (string planetPositionAsString in args)
        {
            try
            {
                int planetPosition = Convert.ToInt32(planetPositionAsString);
                if (planetPosition > 0 && planetPosition < 10)
                {
                    int lastLength = planetPositions.Length;
                    Array.Resize(ref planetPositions,  lastLength + 1);
                    planetPositions[lastLength] = planetPosition;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{1}: {0}", planetPositionAsString, e.Message);
            }
        }
        string[] planetNames = PlanetsFromPositions(planetPositions);
        Console.WriteLine("finish planet name search, found planets:");
        foreach (string planet in planetNames)
        {
            Console.WriteLine(planet);
        }
    }

    Application();