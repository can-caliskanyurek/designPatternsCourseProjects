namespace CopyThroughSerialization.Classes
{
    public class Address
    {
        public string StreetName;
        public int HouseNumber;

        public Address(string streetName, int houseNumber)
        {
            StreetName = streetName;
            HouseNumber = houseNumber;
        }

        public Address(Address address)
        {
            StreetName = address.StreetName;
            HouseNumber = address.HouseNumber;
        }

        public override string ToString()
        {
            return $"{nameof(StreetName)}: {StreetName}\n\t{nameof(HouseNumber)}: {HouseNumber}";
        }
    }
}
