namespace ChristmasChallenge
{
    /**
    * Mikołaj znów przyoszczedził na pakiecie. Tym razem dla ilości zmiennych.
    * Kupił sobie tylko dwie: jedną, żeby zapisać ilość miejsc do odwiedzenia,
    * a drugą, żeby zapisać ilość reniferów.
    * Niestety! W ferworze świątecznych przygotowań pomylił się i przypisał wartości na odwrót!
    * Pomoż Mikołajowi i zamień wartości. Pamiętaj, żeby nie używać żadnych dodatkowych zmiennych!
    * Grozi Mikołajowi za to duża kara pieniężna i gdyby ją otrzymał, nie miał by pieniędzy na prezenty!
    */

    internal class Day21_SwapValues : IShowResult
    {
        public void ShowResult()
        {
            int places = 10;
            int reindeers = 100;

            Console.WriteLine("Before switch: places = " + places);
            Console.WriteLine("Before switch: reindeers = " + reindeers);

            places = places ^ reindeers;
            reindeers = places ^ reindeers;
            places = places ^ reindeers;

            Console.WriteLine("After switch: places = " + places);
            Console.WriteLine("After switch: reindeers = " + reindeers);
        }
    }
}
