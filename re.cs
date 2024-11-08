Console.Title = "CloudCMD";
string version = "[v1.0.1]";
Console.WriteLine($"CloudCMD {version}\n");
Console.WriteLine("Enter 'help' to learn the commands\n");
while (true)
{
    Console.Write("CloudCMD\\>");
    string command = Console.ReadLine();
    string phrase = "";
    if (command.StartsWith("help"))
    {
        if (command != "help")
        {
            phrase = command.Substring(5);
            if (phrase == "say")
            {
                Console.WriteLine("'say' repeates a phrase back\nex. 'say Hello World!' returns 'Hello World'");
            }
        }
        else if (command == "help")
        {
            Console.WriteLine("Helps with a command\nex. 'help say' returns info for the say command\nAvalible Commands:\nhelp\nsay");
        }
    }
    else if (command == "clear")
    {
        Console.Clear();
        Console.WriteLine($"CloudCMD {version}\n");
        Console.WriteLine("Enter 'help' to learn the commands\n");
    }
    else if (command.StartsWith("say"))
    {
        if (command != "say")
        {
            string tosay = command.Substring(5);
        }
    }
    else { Console.WriteLine($"'{command}' does not exist"); }
}
