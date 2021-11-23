using System;

namespace PointLib
{
    public class Point
    {
        public int X{ get; set; }
        public int Y{ get; set; }


        public void PrintIt()
        {
            System.Console.WriteLine(ToString());
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(){X=p1.X + p2.X, Y=p1.Y + p2.Y};
        }

        public static Point operator +(Point p)
        {
            p.X += 1;
            p.Y += 1;
            return p;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public static explicit operator int(Point point)
        {
            return point.X + point.Y;
        }
    }
}
