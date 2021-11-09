using System;

namespace ArraysLib
{
    public class Arrays
    {
        public static void Run()
        {
            var size = (int) Math.Pow(10, 6);
            int[] arr = new int[size];
            var start = System.DateTime.Now;
            for (int i = 0; i < size; i++)
            {
                arr[i] = i;
            }
            var stop = System.DateTime.Now;
            System.Console.WriteLine($"Insertion time: {stop - start}");
            long sum = 0;
            start = System.DateTime.Now;
            foreach (var item in arr)
            {
                sum += item;
            }
            stop = System.DateTime.Now;
            System.Console.WriteLine($"Insertion time: {stop - start}");
            System.Console.WriteLine($"sum = {sum}");
        }

        public static void RunObj()
        {
            var size = (int) Math.Pow(10, 6);
            object[] arr = new object[size];
            var start = System.DateTime.Now;
            for (int i = 0; i < size; i++)
            {
                arr[i] = i;
            }
            var stop = System.DateTime.Now;
            System.Console.WriteLine($"Insertion time: {stop - start}");
            long sum = 0;
            start = System.DateTime.Now;
            foreach (var item in arr)
            {
                sum += (int) item;
            }
            stop = System.DateTime.Now;
            System.Console.WriteLine($"Insertion time: {stop - start}");
            System.Console.WriteLine($"sum = {sum}");
        }
    }
}
