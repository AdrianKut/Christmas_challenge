
namespace ChristmasChallenge
{   
    public class Day8DuplicatedAddresses : IShowResult
    {
        public void ShowResult()
        {
            List<Address> addressesWithoutDuplicates = Address.PrepareAddresses()
                .Distinct(new DistinctAddressesComparer()).ToList();

            foreach (Address address in addressesWithoutDuplicates)
                address.ShowAddress();
        }
    }
}
