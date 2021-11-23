using System;
using System.Collections.Generic;

namespace PointLib
{
    public class Cluster
    {
        public List<Point> points{ get; set; }

        public Point GetCentroid()
        {
            int accumulatedArea = 0;
            int centerX = 0;
            int centerY = 0;

            for (int i = 0, j = points.Count - 1; i < points.Count; j = i++)
            {
                int temp = points[i].X * points[j].Y - points[j].X * points[i].Y;
                accumulatedArea += temp;
                centerX += (points[i].X + points[j].X) * temp;
                centerY += (points[i].Y + points[j].Y) * temp;
            }

            if (Math.Abs(accumulatedArea) < 1E-7)
                return new Point();  // Avoid division by zero

            accumulatedArea *= 3;
            return new Point(){X=centerX /(int) accumulatedArea, Y=centerY /(int) accumulatedArea};
        }


    }
}
