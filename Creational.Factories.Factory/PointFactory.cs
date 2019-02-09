﻿namespace Creational.Factories.Factory
{
    internal class PointFactory
    {
        public static Point NewCartesianPoint(float x, float y)
        {
            return new Point(x, y); // needs to be public
        }
    }
}