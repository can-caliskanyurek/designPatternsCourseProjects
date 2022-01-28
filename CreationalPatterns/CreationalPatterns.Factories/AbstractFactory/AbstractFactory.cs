using AbstractFactory.Classes;
using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    public class AbstractFactory
    {
        public static void Main(string[] args)
        {
            //HotDrinkMachine machine = new HotDrinkMachine();
            //IHotDrink drink = machine.MakeDrink(HotDrinkMachine.AvailableDrink.Tea, 100);
            //drink.Consume();

            HotDrinkMachineWithOCP machine = new HotDrinkMachineWithOCP();
            IHotDrink drink = machine.MakeDrink();
            drink.Consume();
        }
    }
}
