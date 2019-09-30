using System;

namespace SharpTriangles.Models
{
    public struct Point : IComparable<Point>, IComparable
    {
        public int Y, X;

        public Point(int y, int x)
        {
            Y = y;
            X = x;
        }

        public int CompareTo(Object o)
        {
            Point other = (Point) o;
            if (other.Y != Y)
                return Y - other.Y;
            else return X - other.X;
        }
        public int CompareTo(Point other)
        {
            if (other.Y != Y)
                return Y - other.Y;
            else return X - other.X;
        }
    }
}