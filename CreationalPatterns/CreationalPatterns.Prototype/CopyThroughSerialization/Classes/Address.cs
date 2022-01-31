using System;

namespace CopyThroughSerialization.Classes
{
    //[Serializable]
    public class Address
    {
        public string StreetName;
        public int HouseNumber;

        public Address()
        {

        }

        public Address(string streetName, int houseNumber)
        {
            StreetName = streetName;
            HouseNumber = houseNumber;
        }

        public override string ToString()
        {
            return $"{nameof(StreetName)}: {StreetName}\n\t{nameof(HouseNumber)}: {HouseNumber}";
        }
    }
}
