using System;
using static System.Console;

namespace Otrzymywanie_argumentow
{
    class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), args[0], true);
            BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), args[1], true);
            WindowWidth = int.Parse(args[2]);
            WindowHeight = int.Parse(args[3]);
            WriteLine($"Otrzymano {args.Length} argumentów.");
            foreach(string arg in args)
            {
                
                WriteLine(arg);
            }
        }
    }
}
