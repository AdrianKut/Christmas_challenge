using System.Security.Cryptography.X509Certificates;

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
            return new string(text.Reverse());
        }

        public void ShowResult()
        {
            List<String> names = new List<string>();
            names.Add("Uisaj");
            names.Add("Aisak");
            names.Add("Aisa");
            names.Add("Kemot");
            names.Add("Lahcim");

            List<String> reversedNames = new List<String>();
            for (int i = 0; i < names.Count; i++)
            {
                string currentName = Reverse(names[i].ToLower());
                reversedNames.Add(currentName[0].ToString().ToUpper() + currentName.Substring(1));
            }

            reversedNames.ForEach(x => Console.WriteLine(x));
        }
    }
}
