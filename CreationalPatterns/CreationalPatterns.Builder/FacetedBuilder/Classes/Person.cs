namespace FacetedBuilder.Classes
{
    public class Person
    {
        // address
        public string StreetAddress, Postcode, City;

        // employment
        public string CompanyName, Position;
        public int AnnualIncome;

        public override string ToString()
        {
            return $"{StreetAddress}, {City}, {Postcode}\n{CompanyName}, {Position}, {AnnualIncome}";
        }
    }
}
