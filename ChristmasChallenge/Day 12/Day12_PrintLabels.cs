namespace ChristmasChallenge
{

    /**
     * Pomóż Mikołajowi przygotować etykiety do druku na prezenty!
     * Dla każdego dziecka z listy wypisz w konsoli imię, nazwisko i adres w formacie jak na list.
     * Rozdziel przygotowane etykiety liniami.
     */

    internal class Day12_PrintLabels : IShowResult
    {
        public void ShowResult()
        {
            List<ChildWithAddress> children = prepareChildren();

            foreach (ChildWithAddress child in children)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("-----------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n{child}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("-----------------\n");
            }

            Console.ForegroundColor = ConsoleColor.White;
        }

        private static List<ChildWithAddress> prepareChildren()
        {
            return new List<ChildWithAddress>()
            {
                new ChildWithAddress(
                            "Jasiu",
                            "Kowalski",
                            new Address("Serniczkowa",
                                    "4B",
                                    2,
                                    "Krakow",
                                    "02-326"
                            )),
                    new ChildWithAddress(
                            "Kasia",
                            "Nowak",
                            new Address("Pierniczkowa",
                                    "289",
                                    55,
                                    "Gdansk",
                                    "02-326"
                            )),
                    new ChildWithAddress(
                            "Asia",
                            "Wisniewska",
                            new Address("Barszczykowa",
                                    "234",
                                    5,
                                    "Rzeszow",
                                    "37-326"
                            )),
                    new ChildWithAddress(
                            "Tomek",
                            "Wojcik",
                            new Address("Uszkowa",
                                    "43H",
                                    5,
                                    "Wroclaw",
                                    "02-326"
                            ))
            };
        }
    }
}
