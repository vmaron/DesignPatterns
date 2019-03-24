using System;
using Structural.Decorator.Dynamic;

namespace Structural.Decorator.Static
{
    public class ColoredShape<T> : Shape where T : Shape, new()
    {
        private readonly string _color;
        private readonly T _shape = new T();

        public ColoredShape() : this("black")
        {
        }

        public ColoredShape(string color) // no constructor forwarding
        {
            _color = color ?? throw new ArgumentNullException(nameof(color));
        }

        public override string AsString()
        {
            return $"{_shape.AsString()} has the color {_color}";
        }
    }
}