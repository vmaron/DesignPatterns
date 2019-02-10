using System;
using System.Collections.Generic;
using MoreLinq;
using Structural.Adapter.WithCaching.Impl;
using Structural.Adapter.WithCaching.Models;

namespace Structural.Adapter.WithCaching
{
    public class Demo
    {
        private static readonly List<VectorObject> VectorObjects = new List<VectorObject>
        {
            new VectorRectangle(1, 1, 10, 10),
            new VectorRectangle(3, 3, 6, 6)
        };

        // the interface we have
        public static void DrawPoint(Point p)
        {
            Console.Write(".");
        }

        private static void Main(string[] args)
        {
            Draw();
            Draw();
        }

        private static void Draw()
        {
            foreach (var vo in VectorObjects)
            foreach (var line in vo)
            {
                var adapter = new LineToPointAdapter(line);
                adapter.ForEach(DrawPoint);
            }
        }
    }
}