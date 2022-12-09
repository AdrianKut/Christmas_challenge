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
        public void ShowResult()
        {
            List<Address> addresses = Address.PrepareAddresses()
                .Distinct(new DistinctAddressesComparer()).ToList();

            Regex regexVowels = new Regex("[aeiou]", RegexOptions.IgnoreCase);
            int vowelsCounter = 0;
            int extraPay = 2;

            addresses.ForEach(x => vowelsCounter 
            += regexVowels.Matches(x.Street).Count()
            + regexVowels.Matches(x.City).Count());

            Console.Write($"\nExtra payment: {(vowelsCounter * extraPay)}");
        }
    }
}
