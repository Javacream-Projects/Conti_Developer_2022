void Application()
{
    bool running = true;
    while(running)
    {
        Console.Write("Enter command: ");
        string command = Console.ReadLine().ToLower();
        switch(command)
        {
            case "split":
            {
                Console.Write("Enter input: ");
                string input = Console.ReadLine();
                string[] words = input.Split(" ");
                foreach(string word in words)
                {
                    Console.WriteLine(word);
                }
                break;
            }
            case "exit":
            {
                running = false;
                break;
            }
            case "reverse":
            {
                Console.Write("Enter input: ");
                string input = Console.ReadLine();
                string reverted = "";
                for (int i = input.Length - 1; i >= 0; i--){
                    reverted += input[i];
                }
                Console.WriteLine(reverted);
                break;
            }
            case "check":
            {
                Console.Write("Enter input: ");
                string input = Console.ReadLine();
                Console.WriteLine(input.StartsWith("TEST"));
                break;
            }
            default:
            {
                Console.WriteLine("unknown command: {0}", command);
                break;
            }

            
        }
    }
}
Application();