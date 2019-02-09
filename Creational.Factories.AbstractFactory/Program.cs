namespace Creational.Factories.AbstractFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var machine = new HotDrinkMachine();
            //var drink = machine.MakeDrink(HotDrinkMachine.AvailableDrink.Tea, 300);
            //drink.Consume();

            var drink = machine.MakeDrink();
            drink.Consume();
        }
    }
}