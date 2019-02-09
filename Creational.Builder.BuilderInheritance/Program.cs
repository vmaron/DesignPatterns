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

    public class Person
    {
        public string Name;

        public string Position;

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
        }

        public class Builder : PersonJobBuilder<Builder>
        {
            /* degenerate */
        }
    }

    public abstract class PersonBuilder<TSelf>
        where TSelf : PersonBuilder<TSelf>
    {
        protected Person Person = new Person();

        public Person Build()
        {
            return Person;
        }
    }

    public class PersonInfoBuilder<TSelf> : PersonBuilder<PersonInfoBuilder<TSelf>>
        where TSelf : PersonInfoBuilder<TSelf>
    {
        public TSelf Called(string name)
        {
            Person.Name = name;
            return (TSelf) this;
        }
    }

    public class PersonJobBuilder<TSelf> : PersonInfoBuilder<PersonJobBuilder<TSelf>>
        where TSelf : PersonJobBuilder<TSelf>
    {
        public TSelf WorksAsA(string position)
        {
            Person.Position = position;
            return (TSelf) this;
        }
    }
}