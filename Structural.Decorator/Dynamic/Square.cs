namespace Structural.Decorator.Dynamic
{
    public class Square : Shape
    {
        private readonly float _side;

        public Square() : this(0)
        {
        }

        public Square(float side)
        {
            _side = side;
        }

        public override string AsString()
        {
            return $"A square with side {_side}";
        }
    }
}