﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasChallenge
{
    public class Address
    {
        public string Street { get; private set; }
        public string HouseNumber { get; private set; }
        public int NumberOfGifts { get; private set; }
        public string City { get; private set; }
        public string StreetCode { get; private set; }

        public Address(string street, string houseNumber, int numberOfGifts, string city, string streetCode)
        {
            this.Street = street;
            this.HouseNumber = houseNumber;
            this.NumberOfGifts = numberOfGifts;
            this.City = city;
            this.StreetCode = streetCode;
        }

        public void ShowAddress()
        {
            Console.WriteLine($"Street: {Street}, HouseNumber: {HouseNumber}, Gifts: {NumberOfGifts}" +
                $", City: {City}, Street: {StreetCode} ");
        }

        public static List<Address> PrepareAddresses()
        {
            List<Address> addresses = new List<Address>();

            addresses.Add(new Address("Serniczkowa", "4B", 2, "Krakow", "02-326"));
            addresses.Add(new Address("Pierniczkowa", "289", 55, "Gdansk", "02-326"));
            addresses.Add(new Address("Pierniczkowa", "289", 55, "Gdansk", "02-326"));
            addresses.Add(new Address("Pierniczkowa", "289", 55, "Gdansk", "02-326"));
            addresses.Add(new Address("Barszczykowa", "234", 5, "Rzeszow", "3-326"));
            addresses.Add(new Address("Uszkowa", "43H", 5, "Wroclaw", "02-326"));
            addresses.Add(new Address("Uszkowa", "43H", 5, "Wroclaw", "02-326"));
            addresses.Add(new Address("Uszkowa", "43H", 5, "Wroclaw", "02-326"));
            addresses.Add(new Address("Cukierkowa", "23", 5, "Poznan", "02-326"));

            return addresses;
        }
    }
}
