using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;

namespace AbstractFactory.Classes
{
    public class HotDrinkMachineWithOCP
    {
        private List<Tuple<string, IHotDrinkFactory>> factories = new List<Tuple<string, IHotDrinkFactory>>();

        public HotDrinkMachineWithOCP()
        {
            // reflection
            foreach (Type type in typeof(HotDrinkMachineWithOCP).Assembly.GetTypes())
            {
                if (typeof(IHotDrinkFactory).IsAssignableFrom(type) && !type.IsInterface)
                {
                    factories.Add(Tuple.Create(
                        type.Name.Replace("Factory", string.Empty),
                        (IHotDrinkFactory)Activator.CreateInstance(type)
                    ));
                }
            }
        }

        public IHotDrink MakeDrink()
        {
            Console.WriteLine("Available drinks: ");

            for (int index = 0; index < factories.Count; index++)
            {
                Tuple<string, IHotDrinkFactory> tuple = factories[index];

                Console.WriteLine($"{index}: {tuple.Item1}");
            }

            while (true)
            {
                string s;

                if ((s = Console.ReadLine()) != null && int.TryParse(s, out int i) && i >= 0 && i < factories.Count)
                {
                    Console.Write("Specify Amount: ");

                    s = Console.ReadLine();

                    if (s != null && int.TryParse(s, out int amount) && amount > 0)
                    {
                        return factories[i].Item2.Prepare(amount);
                    }
                }

                Console.WriteLine("Incorrect input, try again!");
            }
        }
    }
}
