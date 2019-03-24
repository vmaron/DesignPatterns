using Structural.Decorator.Dynamic;

namespace Structural.Decorator.Static
{
    public class TransparentShape<T> : Shape where T : Shape, new()
    {
        private readonly T _shape = new T();
        private readonly float _transparency;

        public TransparentShape(float transparency)
        {
            this._transparency = transparency;
        }

        public override string AsString()
        {
            return $"{_shape.AsString()} has transparency {_transparency * 100.0f}";
        }
    }
}