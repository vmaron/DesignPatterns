using System;
using Structural.Decorator.Dynamic;
using Structural.Decorator.Static;

namespace Structural.Decorator
{
    public class Demo
    {
        private static void Main(string[] args)
        {
            var square = new Square(1.23f);
            Console.WriteLine(square.AsString());

            var redSquare = new ColoredShape(square, "red");
            Console.WriteLine(redSquare.AsString());

            var redHalfTransparentSquare = new TransparentShape(redSquare, 0.5f);
            Console.WriteLine(redHalfTransparentSquare.AsString());

            // static
            var blueCircle = new ColoredShape<Circle>("blue");
            Console.WriteLine(blueCircle.AsString());

            var blackHalfSquare = new TransparentShape<ColoredShape<Square>>(0.4f);
            Console.WriteLine(blackHalfSquare.AsString());
        }
    }
}