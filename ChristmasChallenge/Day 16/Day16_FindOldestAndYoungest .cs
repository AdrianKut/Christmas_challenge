using ChristmasChallenge.Day_16;

namespace ChristmasChallenge
{
    internal class Day16_FindOldestAndYoungest : IShowResult
    {
        private static List<ChildWithBirthDate> prepareChildren()
        {
            return new List<ChildWithBirthDate>() {
                new ChildWithBirthDate(
                            "Jasiu",
                            "Kowalski",
                            new DateTime(2010, 12, 30)),
                new ChildWithBirthDate(
                            "Kasia",
                            "Nowak",
                            new DateTime(2011, 11, 30)),
                new ChildWithBirthDate(
                            "Asia",
                            "Wisniewska",
                            new DateTime(2010, 12, 31)),
                new ChildWithBirthDate(
                            "Tomek",
                            "Wojcik",
                            new DateTime(2015, 6, 30)),
                new ChildWithBirthDate(
                            "Tomek",
                            "Zajac",
                            new DateTime(2020, 12, 30))
            };
        }

        public void ShowResult()
        {
            List<ChildWithBirthDate> childWithBirths = prepareChildren();
            BirthdayComparer birthdayComparer = new BirthdayComparer();
            childWithBirths.Sort(birthdayComparer);

            foreach (var item in childWithBirths)
            {
                Console.WriteLine(item);
            }
        }
    }
}
