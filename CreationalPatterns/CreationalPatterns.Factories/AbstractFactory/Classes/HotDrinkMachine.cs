using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;

namespace AbstractFactory.Classes
{
    public class HotDrinkMachine
    {
        public enum AvailableDrink
        {
            Coffee, Tea
        }

        private Dictionary<AvailableDrink, IHotDrinkFactory> factories = new Dictionary<AvailableDrink, IHotDrinkFactory>();

        public HotDrinkMachine()
        {
            foreach (AvailableDrink drink in Enum.GetValues(typeof(AvailableDrink)))
            {
                IHotDrinkFactory factory = (IHotDrinkFactory)Activator.CreateInstance(
                    Type.GetType("AbstractFactory.Classes." + Enum.GetName(typeof(AvailableDrink), drink) + "Factory")
                );

                factories.Add(drink, factory);
            }
        }

        public IHotDrink MakeDrink(AvailableDrink drink, int amount)
        {
            return factories[drink].Prepare(amount);
        }
    }
}
