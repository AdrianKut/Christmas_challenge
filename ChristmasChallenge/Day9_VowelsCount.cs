using System.Text.RegularExpressions;

namespace ChristmasChallenge
{
    /**
     * Mikołaj wykupił pakiet wysyłkowy do prezentów, ale przyoszczędził na wersji premium.
     * Przez to będzie musiał dopłacić 2 zł za każdą samogłoskę w adresie.
     * Pomóż Mikołajowi i policz ile będzie musiał dopłacić, a policzoną wartość wypisz na ekranie.
     * Adresy znajdziesz w przygotowanej liście, nie ma w nich polskich znaków.
     */

    internal class Day9_VowelsCount : IShowResult
    {
        private static List<Address> PrepareAddresses()
        {
            List<Address> addresses = new List<Address>();

            addresses.Add(new Address("Serniczkowa",
                    "4B",
                    2,
                    "Krakow",
                    "02-326"
            ));
            addresses.Add(new Address("Pierniczkowa",
                    "289A",
                    55,
                    "Gdansk",
                    "02-326"
            ));
            addresses.Add(new Address("Barszczykowa",
                    "234",
                    5,
                    "Rzeszow",
                    "37-326"
            ));
            addresses.Add(new Address("Uszkowa",
                    "43H",
                    5,
                    "Wroclaw",
                    "02-326"
            ));
            addresses.Add(new Address("Cukierkowa",
                    "23I",
                    5,
                    "Poznan",
                    "02-326"
            ));

            return addresses;
        }

        public void ShowResult()
        {
            Regex regexVowels = new Regex("[eayiou]", RegexOptions.IgnoreCase);
            int vowelsCounter = 0;
            int extraPay = 2;

            List<Address> addresses = PrepareAddresses();

            addresses.ForEach(x => vowelsCounter
            += regexVowels.Matches(x.Street).Count()
            + regexVowels.Matches(x.City).Count()
            + regexVowels.Matches(x.HouseNumber).Count()
            );

            Console.Write($"Extra payment: {(vowelsCounter * extraPay)}");
        }
    }
}
