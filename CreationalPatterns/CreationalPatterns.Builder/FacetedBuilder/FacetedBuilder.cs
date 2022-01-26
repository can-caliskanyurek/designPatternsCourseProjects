using FacetedBuilder.Classes;
using System;

namespace FacetedBuilder
{
    public class FacetedBuilder
    {
        public static void Main(string[] args)
        {
            PersonBuilder personBuilder = new PersonBuilder();
            Person person = personBuilder
                .Lives.At("123 Gölbaşı")
                      .In("Ankara")
                      .WithPostcode("06830")
                .Works.At("Türkiye Petrolleri A.O.")
                      .AsA("Software Engineer")
                      .Earning(36000);

            Console.WriteLine(person);
        }
    }
}
