using System;
using System.Diagnostics;
namespace General
{
  class MainClass
  {
    static System.Diagnostics.Process process = new System.Diagnostics.Process();
    static System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
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
        string words = command.Length > 3 ? command.Substring(3).Trim() : string.Empty;
        Console.WriteLine($"[>] {words}");
      }
      else if (command.ToLower().StartsWith("pystall"))
      {
        string package = command.Length > 7 ? command.Substring(7).Trim() : string.Empty;
        startInfo.WindowStyle = ProcessWindowStyle.Hidden;
        startInfo.FileName = "cmd.exe";
        startInfo.Arguments = $"/C pip install {package}"; // Corrected to execute with cmd /C
        startInfo.RedirectStandardOutput = true;
        startInfo.RedirectStandardError = true;
        startInfo.UseShellExecute = false;
        startInfo.CreateNoWindow = true;
        process.StartInfo = startInfo;
        process.Start();
      }
      else if (command.ToLower().StartsWith("run")
      else
      {
        Console.WriteLine($"[>] '{command}' does not exist");
      }
    }
  }
}
