namespace ChristmasChallenge
{
    /**
    * W świeta lubimy śpiewać koledy i świąteczne piosenki. Przygotuj prompter dla koledy lub piosenki.
    * Niech tekst linijka po linijce wyświetla sie co 3 sekunde w terminalu.
    * Przykladowy tekst znajdziesz ponizej, ale mozesz zamienić go na tekst Twojej ulubionej piosenki lub koledy!
    */

    internal class Day18_SongPrompter : IShowResult
    {
        private void PlayRandomBeep(int duration)
        {
            Random random = new Random();
            int randomBeep = random.Next(100, 1000);
            Console.Beep(randomBeep, duration);
        }

        private void PlaySoundFromText(string text, int textSpeedPerLaneInMilliseconds)
        {
            var textLine = text.Split("\n");
            var startTextSpeed = textSpeedPerLaneInMilliseconds;

            for (int i = 0; i < textLine.Length; i++)
            {
                textSpeedPerLaneInMilliseconds = startTextSpeed;
                var duration = textSpeedPerLaneInMilliseconds / (textLine[i].Length);
                
                for (int j = 0; j < textLine[i].Length; j++)
                {
                    PlayRandomBeep(duration);
                    Console.Write(textLine[i][j]);
                }
                Console.WriteLine();
            }
        }

        public void ShowResult()
        {
            string lyrics = "Bog sie rodzi, moc truchleje\n"
+ "Pan niebiosow obnazony!\n"
+ "Ogien krzepnie, blask ciemnieje.\n"
+ "Ma granice Nieskonczony\n"
+ "Wzgardzony, okryty chwala\n"
+ "Smiertelny Krol nad wiekami!\n"
+ "A Slowo Cialem sie stalo\n"
+ "I mieszkalo miedzy nami :)";

            PlaySoundFromText(lyrics, 3000);
        }
    }
}
