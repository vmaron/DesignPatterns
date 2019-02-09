namespace Creational.Builder.BuilderInheritance
{
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
}