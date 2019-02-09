namespace Creational.Builder.BuilderInheritance
{
    public class PersonInfoBuilder<TSelf> : PersonBuilder<PersonInfoBuilder<TSelf>>
        where TSelf : PersonInfoBuilder<TSelf>
    {
        public TSelf Called(string name)
        {
            Person.Name = name;
            return (TSelf) this;
        }
    }
}