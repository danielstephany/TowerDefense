using System;

namespace TowerDefense
{
    class Point 
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int DistanceTo(int x, int y)
        {
            // Cartesian Distance Formula
            return (int) Math.Round(Math.Sqrt(Math.Pow(this.X - x, 2) + Math.Pow(Y - y, 2)), 2);
        }
        //overload DistanceTo to take a Point
        public int DistanceTo(Point p)
        {
            return DistanceTo(p.X, p.Y);
        }
    }
}