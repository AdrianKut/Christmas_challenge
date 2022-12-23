﻿namespace ChristmasChallenge
{
    /**
    * Mikołaj postanowił w tym roku skorzytać z pomocy nowoczesnych technologii.
    * Zamiast kupować choinkę i ozdoby postanowił użyć takich wygenerowanych w konsoli
    * Pomoż Mikołajowi! Przygotuj kod, który wypisze na ekranie kokardkę na choinkę.
    * Jeżeli potrafisz, nie wpisuj kokardki bezpośrednio w printy - pokombinuj z pętlami.
    * Tak, żeby kokardka wygenerowała się sama!
    */

    internal class Day23_ChristmasBow : IShowResult
    {
        private void ShowPatternDependOfState(bool state)
        {
            if (state)
                ShowSymbolWithColor('$', ConsoleColor.Red);
            else
                ShowSymbolWithColor('$', ConsoleColor.Yellow);
        }

        private void DecreaseSizeAfterHalfChristmasBow(ref int height, ref bool increaseSize, int i)
        {
            if (i == height / 2 && increaseSize)
            {
                height = 0;
                increaseSize = false;
            }
        }

        private void ShowSymbolWithColor(char symbol, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(symbol);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void ShowResult()
        {
            int height = 15;
            bool increaseSize = true;

            for (int i = height - 1; i >= -1; i--)
            {
                Console.Write("|");

                if (increaseSize)
                {
                    for (int j = i - (height / 2); j > 0; j--)
                    {
                        ShowPatternDependOfState(j % 2 == 0);
                    }
                    Console.Write("/");
                }
                else
                {
                    for (int j = height; j > 0; j--)
                    {
                        ShowPatternDependOfState(j % 2 != 0);
                    }

                    Console.Write("\\");
                    height++;
                }

                Console.WriteLine();

                DecreaseSizeAfterHalfChristmasBow(ref height, ref increaseSize, i);
            }
        }
    }
}


