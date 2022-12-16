namespace ChristmasChallenge.Day_16
{
    internal class BirthdayComparer : IComparer<ChildWithBirthDate>
    {
        public int Compare(ChildWithBirthDate x, ChildWithBirthDate y)
        {
            if (x.Birthday > y.Birthday)
            {
                return -1;
            }
            if (x.Birthday < y.Birthday)
            {
                return 1;
            }

            return 0;
        }
    }

}
