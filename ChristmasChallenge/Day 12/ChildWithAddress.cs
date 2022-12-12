using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasChallenge
{
    internal class ChildWithAddress
    {
        public String Name { get; private set; }
        public String Surname { get; private set; }
        public Address Address { get; private set; }

        public ChildWithAddress(string name, string surname, Address address)
        {
            Name = name;
            Surname = surname;
            Address = address;
        }

        public override string? ToString()
        {
            return new string($"{Name} {Surname}\n{Address}");
        }
    }
}
