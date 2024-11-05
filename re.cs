using System;
class Main
{
  static void Main(string[] args)
  {
    while (true)
    {
      Console.Write("[>] ");
      string command = Console.ReadLine();
      parseCmds();
    }
  }
  static void parseCmds()
  {
    if (command == "help")
    {
      string second = command[4:]
      cmds.doHelp(second)
    }
  }
}
