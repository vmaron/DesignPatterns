using System;

namespace Creational.Builder.BuilderFacets
{
    public class Demo
    {
        private static void Main(string[] args)
        {
            var pb = new PersonBuilder();
            Person person = pb
                .Lives
                .At("123 London Road")
                .In("London")
                .WithPostcode("SW12BC")
                .Works
                .At("Fabrikam")
                .AsA("Engineer")
                .Earning(123000);

            Console.WriteLine(person);
        }
    }
}