using System;

namespace TypesLib
{
    public class Test
    {
        public static void Print()
        {
            // Fruit f = Fruit.Banana;
            // Console.WriteLine($"{f}");
            System.Array l = System.Enum.GetValues(typeof(System.ConsoleColor));
            foreach (var value in l)
            {
                System.Console.WriteLine($"{value}");
            }
        }
    }

    public enum Fruit
    {
        Apple=3, Pear=2, Banana
    }
}
