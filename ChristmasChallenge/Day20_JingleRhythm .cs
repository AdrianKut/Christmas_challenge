namespace ChristmasChallenge
{
    /***
    * Świąteczne piosenki to coś co lubimy wszyscy. Niektórzy lubią ich słuchać, ale niektorzy także grać na pianinie!
    * Przygotuj symulator rytmu piosenki Jingle Bells. W tablicy poniżej znajdziesz długości kolejnych nut.
    * Na terminalu wypisuj kolejne gwiazdki dla każdej nuty przez określony długością nuty czas.
    * Przykładowo 300ms * czas określony dla nuty w tablicy. Dla efektu dźwiękowego możesz też użyć beep!
    */

    internal class Day20_JingleRhythm : IShowResult
    {
        private void Beep(int frequency, int duration)
        {
            Console.Beep(frequency, duration);
        }

        private void RandomConsoleColor()
        {
            ConsoleColor[] consoleColors = {ConsoleColor.Red, ConsoleColor.Green,ConsoleColor.Blue,
                ConsoleColor.Yellow, ConsoleColor.Cyan, ConsoleColor.Gray, ConsoleColor.Magenta};

            Random random = new Random();
            Console.ForegroundColor = consoleColors[random.Next(0, consoleColors.Length)];
        }

        private void PlayJingleBells(int[] tones, char[] letters_notes, Dictionary<char, int> notesWithFrequency)
        {
            for (int i = 0; i < letters_notes.Length; i++)
            {
                int currentFrequency = notesWithFrequency[letters_notes[i]];
                int currentDuration = tones[i] * 150;

                RandomConsoleColor();
                Console.Write(" * ");
                Console.Beep(currentFrequency, currentDuration);
            }
        }

        public void ShowResult()
        {
            int[] tones = {
                2, 2, 4, 2, 2, 4, 2, 2, 2, 1, 8, 2, 2, 2, 1, 2, 2, 2, 1, 1,
                2, 2, 2, 2, 4, 4, 2, 2, 4, 2, 2, 4, 2, 2, 2, 1, 8, 2, 2, 2, 1,
                2, 2, 2, 1, 1, 2, 2, 2, 2, 8, 2, 2, 2, 2, 4, 1, 1, 2, 2, 2, 2, 8,
                2, 2, 2, 2, 8, 2, 2, 2, 2, 8, 2, 2, 2, 2, 8,
                2, 2, 2, 2, 4, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 8
            };

            char[] letters_notes = {'E', 'E', 'E', 'E', 'E', 'E', 'E', 'G', 'C', 'D', 'E', 'F', 'F', 'F', 'F', 'F', 'E', 'E',
                 'E', 'E', 'E', 'D', 'D', 'E', 'D', 'G', 'E', 'E', 'E', 'E', 'E', 'E', 'E', 'G', 'C', 'D',
                 'E', 'F', 'F', 'F', 'F', 'F', 'E', 'E', 'E', 'E', 'G', 'G', 'F', 'D', 'C', 'D', 'B', 'A',
                 'G', 'D', 'D', 'D', 'D', 'B', 'A', 'G', 'E', 'E', 'c', 'B', 'A', 'F', 'D', 'D', 'c', 'A',
                 'B', 'D', 'B', 'A', 'G', 'D', 'D', 'B', 'A', 'G', 'E', 'E', 'E', 'c', 'B', 'A', 'D', 'D',
                 'D', 'D', 'E', 'D', 'c', 'A', 'G'};

            Dictionary<char, int> notesWithFrequency = new Dictionary<char, int>()
            {
                {'c',262},
                {'C',261},
                {'D',293},
                {'E',329},
                {'F',349},
                {'G',392},
                {'B',400},
                {'A',440}
            };

            PlayJingleBells(tones, letters_notes, notesWithFrequency);
        }
    }
}
