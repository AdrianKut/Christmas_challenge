using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasChallenge
{
    public static class ConsoleColorizer
    {
        public static void ShowSymbolWithColor(char symbol, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(symbol);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void RandomConsoleColor()
        {
            ConsoleColor[] consoleColors = {ConsoleColor.Red, ConsoleColor.Green,ConsoleColor.Blue,
                ConsoleColor.Yellow, ConsoleColor.Cyan, ConsoleColor.Gray, ConsoleColor.Magenta};

            Random random = new Random();
            Console.ForegroundColor = consoleColors[random.Next(0, consoleColors.Length)];
        }
    }
}
