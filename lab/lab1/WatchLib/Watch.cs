using System;

namespace WatchLib
{
    public class Watch
    {
        public static void Timer(System.DateTime endTime)
        {
            Console.CursorVisible = false;
            while (System.DateTime.Now <= endTime)
            {
                 var diff = endTime - System.DateTime.Now;
                 Console.SetCursorPosition(Console.WindowWidth-diff.ToString().Length, 0);
                 System.Console.WriteLine($"{diff}");
            }
            Console.CursorVisible = true;
        }
    }
}
