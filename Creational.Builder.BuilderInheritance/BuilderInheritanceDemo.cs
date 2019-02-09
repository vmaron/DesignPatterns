using System;

namespace Creational.Builder.BuilderInheritance
{
    public class BuilderInheritanceDemo
    {
        private static void Main(string[] args)
        {
            var builder = new Person.Builder();
           
            var person = builder.WorksAsA("Developer").Called("John Doe").Build();
            Console.WriteLine(person.ToString());
        }
    }
}