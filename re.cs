using System;
namespace General
{
  class MainClass
  {
    static void Main(string[] args)
    {
      while (true)
      {
        Console.Write("[>] ");
        string command = Console.ReadLine();
        parseCmds(command);
      }
    }
    static void parseCmds(string command)
    {
      if (command.ToLower().StartsWith("help"))
      {
        string second = command.Length > 4 ? command.Substring(4).Trim() : string.Empty;
        cmds.doHelp(second);
      } 
      else if (command.ToLower().StartsWith("say"))
      {
        string words = command.Length > 3 ? command.Substring(4).Trim() : string.Empty;
        Console.WriteLine($"[>] {words}");
      }
      else
      {
        Console.WriteLine($"[>] '{command}' does not exist");
      }
    }
  }
}
