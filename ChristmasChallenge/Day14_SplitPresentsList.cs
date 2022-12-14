namespace ChristmasChallenge
{
    /**
     * Lista prezentów od dzieci przychodzi w jednym długim napisie.
     * Napis zawiera dane w formacie: imię dziecka, spacja, prezenty rozdzielone spacjami, przecinek.
     * Pomóż Mikołajowi! Podziel napis na ciągi: imię dziecka => prezenty po przecinku.
     * Po ostatnim prezencie w linii nie powinno byc przecinka.
     */

    internal class Day14_SplitPresentsList : IShowResult
    {
        public void ShowResult()
        {
            String giftsList = "Kuba klocki klawiatura dron quad, Alicja komputer samochod mysz, "
               + "Janina ksiazka traktor, Tomek kuchenka koparka flamastry, ";

            string[] childrenWithGift = giftsList.Trim().Split(' ');

            for (int i = 0; i < childrenWithGift.Length; i++)
            {
                if (char.IsUpper(childrenWithGift[i][0]))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n" + childrenWithGift[i] + " => ");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                if (childrenWithGift[i].Contains(','))
                {
                    Console.Write(childrenWithGift[i].Trim().Replace(',', ' '));
                    continue;
                }
                Console.Write(childrenWithGift[i].Trim() + ", ");
            }
        }
    }
}
