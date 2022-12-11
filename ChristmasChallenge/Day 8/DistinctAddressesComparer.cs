using System.Diagnostics.CodeAnalysis;

namespace ChristmasChallenge
{
    public class DistinctAddressesComparer : IEqualityComparer<Address>
    {
        public bool Equals(Address x, Address y)
        {
            return x.Street == y.Street &&
                x.HouseNumber == y.HouseNumber &&
                x.City == y.City &&
                x.StreetCode == y.StreetCode;
        }

        public int GetHashCode([DisallowNull] Address obj)
        {
            return obj.Street.GetHashCode() ^
                obj.HouseNumber.GetHashCode() ^
                obj.City.GetHashCode() ^
                obj.StreetCode.GetHashCode();
        }
    }

}
