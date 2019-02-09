namespace Creational.Builder.BuilderInheritance
{
    public abstract class PersonBuilder<TSelf>
        where TSelf : PersonBuilder<TSelf>
    {
        protected Person Person = new Person();

        public Person Build()
        {
            return Person;
        }
    }
}