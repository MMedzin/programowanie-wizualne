using System;
using MathLib;
using WorkersLib;
using Printables;
using OfficeLib;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            // float res;
            // float x = 7;
            // System.Console.WriteLine((new MathFun()).SumDiv(ref x, out res, 1, 2, 5, 10, -1, 0));
            // System.Console.WriteLine(res);
            // System.Console.WriteLine(x);
            
            // System.Console.WriteLine((new MathFun()).Div(y: 3,x: 2));

            // Point p3 = new Point();
            // p3.Print();

            // Point p1 = new Point();
            // p1.X = 1;
            // p1.Y = 1;
            // Point p2 = p1;
            // p2.Print();
            // p1.X = 2;
            // p2.Print();

            // Point p1 = new Point();
            // p1.X = 1;
            // p1.Y = 1;
            // Point.Add1(p1);
            // p1.Print();

            // Nullable<bool> x = null;
            // if (x??false) 
            // {
            //     System.Console.WriteLine("Ok");
            // }
            // System.Console.WriteLine(x?.Equals(true));

            // Supervisor ow = new Supervisor("Jan", "Manager", System.DateTime.Now);
            // // System.Console.WriteLine(ow);
            // ((IPrintable) ow).Print();
            // ((IPublicPrintable) ow).Print();

            Office o = new Office();
            foreach (IPublicPrintable item in o.GetCounterAlphabetical())
            {
                item.Print();
            }
        }
    }
}
