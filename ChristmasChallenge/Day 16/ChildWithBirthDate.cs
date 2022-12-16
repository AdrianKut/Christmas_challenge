using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasChallenge.Day_16
{
    internal class ChildWithBirthDate
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public DateTime Birthday { get; private set; }

        public ChildWithBirthDate(string name, string surname, DateTime birthday)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
        }

        public override string? ToString()
        {
            return new string($"Name: {Name}, Surname: {Surname}, Birthday: {Birthday.ToShortDateString()}");
        }
    }
}
