using System;
using PointLib;
using System.Collections.Generic;
using ExtensionsLib;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            // Point p1 = new Point(){X=1, Y=1};
            // Point p2 = new Point(){X=1, Y=2};
            // (p1 + p2).PrintIt();
            // (+p1).PrintIt();

            // Cluster c = new Cluster(){ 
            //     points= new List<Point>() 
            //     {
            //         new Point(){X=1, Y=1},
            //         new Point(){X=1, Y=2},
            //         new Point(){X=5, Y=7},
            //         new Point(){X=4, Y=9}
            //     } 
            // };
            // c.GetCentroid().PrintIt();

            // Point pz = new Point() { X = 2, Y = 2 };
            // pz.PrintIt();
            // Console.WriteLine(pz);

            int num = 123456;
            System.Console.WriteLine(num.Reverse());
            System.Console.WriteLine(num.SumOfDigits());
        }
    }
}
