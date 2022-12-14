using System.Globalization;
using System.Text;

namespace ChristmasChallenge
{
    internal class Day13_RevertNames : IShowResult
    {

        /**
         * Chochliki nie ułatwiają życia Mikołajowi. Tym razem poodwracały imiona dzieci na liście…
         * Napraw co popsuły chochliki i odwróć imiona.
         * Zwróć uwagę na duże litery i zamień je, tak, żeby imiona były poprawne.
         * Na koniec wypisz listę w terminalu żeby sprawdzić, czy wszystko jest ok!
        */

        public string Reverse(string text)
        {
            return new string(text.Reverse().ToArray());
        }

        public void ShowResult()
        {
            List<String> names = new List<string>();
            names.Add("Uisaj");
            names.Add("Aisak");
            names.Add("Aisa");
            names.Add("Kemot");
            names.Add("Lahcim");

            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            names.ForEach(name => Console.WriteLine((Reverse(name.ToUpper())[0] + (Reverse(name.ToLower()).Substring(1)))));
        }
    }
}
