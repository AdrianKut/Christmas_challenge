using System.Text;

namespace ChristmasChallenge
{
    internal class Day10_ChristmasCandy : IShowResult
    {

        /**
         * Mikołaj postanowił w tym roku skorzytać z pomocy nowoczesnych technologii.
         * Zamiast kupować choinkę i ozdoby postanowił użyć takich wygenerowanych w konsoli (terminalu)
         * Pomoż Mikołajowi! Przygotuj kod, który wypisze na ekranie laskę cukrową.
         * Jeżeli potrafisz, nie wpisuj laski bezpośrednio w printy - pokombinuj z pętlami.
         * Tak, żeby laska wygenerowała się sama!
         */

        public void ShowConsoleTextWithColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }


        public void ShowResult()
        {
            int height = 13;
            StringBuilder sB = new StringBuilder();

            for (int i = 0; i < height; i++)
            {
                if (i % 2 == 0)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.White;

                if (i == 0)
                {
                    ShowConsoleTextWithColor(" *** ", ConsoleColor.Red);
                    continue;
                }
                if (i == 1)
                {
                    ShowConsoleTextWithColor("*   *", ConsoleColor.White);
                    continue;
                }
                if (i == 2)
                {
                    ShowConsoleTextWithColor("*   *", ConsoleColor.Red);
                    continue;
                }
                if (i == 3)
                {
                    ShowConsoleTextWithColor("*   *", ConsoleColor.White);
                    continue;
                }
                Console.WriteLine("*");
            }


        }
    }
}
