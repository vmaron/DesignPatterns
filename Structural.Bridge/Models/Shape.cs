using Structural.Bridge.Impl;

namespace Structural.Bridge.Models
{
    public abstract class Shape
    {
        protected IRenderer Renderer;

        // a bridge between the shape that's being drawn an
        // the component which actually draws it
        protected Shape(IRenderer renderer)
        {
            Renderer = renderer;
        }

        public abstract void Draw();
        public abstract void Resize(float factor);
    }
}