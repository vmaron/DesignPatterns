using System;

namespace Creational.Singleton.Monostate
{
    public class Demo
    {
        private static void Main(string[] args)
        {
            var ceo = new ChiefExecutiveOfficer();
            ceo.Name = "Adam Smith";
            ceo.Age = 55;

            var ceo2 = new ChiefExecutiveOfficer();
            Console.WriteLine(ceo2);
        }
    }
}