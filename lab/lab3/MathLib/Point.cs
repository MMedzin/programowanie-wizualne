using System;

namespace MathLib 
{
    public class Point
    {
        public int X;
        public int Y;

        public void Print()
        {
            System.Console.WriteLine($"X:{X}, Y:{Y}");
        }

        public static void Add1(Point point)
        {
            point.X += 1;
            point.Y += 1;
        }
    }
}