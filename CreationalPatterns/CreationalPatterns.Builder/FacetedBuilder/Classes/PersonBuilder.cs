namespace FacetedBuilder.Classes
{
    public class PersonBuilder // facade
    {
        // reference!
        protected Person person = new Person();

        public PersonJobBuilder Works => new PersonJobBuilder(person);
        public PersonAddressBuilder Lives => new PersonAddressBuilder(person);


        public static implicit operator Person(PersonBuilder personBuilder)
        {
            return personBuilder.person;
        }
    }
}
