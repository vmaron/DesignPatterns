using System;

namespace Structural.Decorator.Dynamic
{
    public class ColoredShape : Shape
    {
        private readonly string _color;
        private readonly Shape _shape;

        public ColoredShape(Shape shape, string color)
        {
            _shape = shape ?? throw new ArgumentNullException(nameof(shape));
            _color = color ?? throw new ArgumentNullException(nameof(color));
        }

        public override string AsString()
        {
            return $"{_shape.AsString()} has the color {_color}";
        }
    }
}