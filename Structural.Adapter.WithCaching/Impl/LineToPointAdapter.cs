﻿using System;
using System.Collections;
using System.Collections.Generic;
using Structural.Adapter.WithCaching.Models;

namespace Structural.Adapter.WithCaching.Impl
{
    public class LineToPointAdapter : IEnumerable<Point>
    {
        private static int _count;
        private static readonly Dictionary<int, List<Point>> Cache = new Dictionary<int, List<Point>>();
        private readonly int _hash;

        public LineToPointAdapter(Line line)
        {
            _hash = line.GetHashCode();
            if (Cache.ContainsKey(_hash))
                return; // we already have it

            Console.WriteLine(
                $"{++_count}: Generating points for line [{line.Start.X},{line.Start.Y}]-[{line.End.X},{line.End.Y}] (with caching)");
            //                                                 ^^^^

            var points = new List<Point>();

            var left = Math.Min(line.Start.X, line.End.X);
            var right = Math.Max(line.Start.X, line.End.X);
            var top = Math.Min(line.Start.Y, line.End.Y);
            var bottom = Math.Max(line.Start.Y, line.End.Y);
            var dx = right - left;
            var dy = line.End.Y - line.Start.Y;

            if (dx == 0)
            {
                for (var y = top; y <= bottom; ++y)
                {
                    points.Add(new Point(left, y));
                }
            }
            else if (dy == 0)
            {
                for (var x = left; x <= right; ++x)
                {
                    points.Add(new Point(x, top));
                }
            }

            Cache.Add(_hash, points);
        }

        public IEnumerator<Point> GetEnumerator()
        {
            return Cache[_hash].GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}