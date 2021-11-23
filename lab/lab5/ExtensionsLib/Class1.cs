using System;

namespace ExtensionsLib
{
    public static class Extensions
    {

        public static int Reverse(this int num)
        {
            int reversed = 0;
            char[] tab = num.ToString().ToCharArray();
            for (int i=0; i < tab.Length; i++)
            {
                reversed += int.Parse(""+tab[i]) * (int)Math.Pow(10, i);
            }
            return reversed;
        }

        public static int SumOfDigits(this int num)
        {
            int sum = 0;
            char[] tab = num.ToString().ToCharArray();
            for (int i=0; i < tab.Length; i++)
            {
                sum += int.Parse(""+tab[i]);
            }
            return sum;
        }

    }
}
