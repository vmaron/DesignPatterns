using System;

namespace Structural.Decorator.Dynamic
{
    public class TransparentShape : Shape
    {
        private readonly Shape _shape;
        private readonly float _transparency;

        public TransparentShape(Shape shape, float transparency)
        {
            _shape = shape ?? throw new ArgumentNullException(nameof(shape));
            _transparency = transparency;
        }

        public override string AsString()
        {
            return $"{_shape.AsString()} has {_transparency * 100.0f}% transparency";
        }
    }
}