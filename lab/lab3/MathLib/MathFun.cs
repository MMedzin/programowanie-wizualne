using System;

namespace MathLib
{
    public class MathFun
    {
        public int Sum(params int[] arg)
        {
            int sum = 0;
            foreach (var item in arg)
            {
                sum += item;
            }
            return sum;
        }

        public int SumAvg(out float avg, params int[] arg)
        {
            int sum = 0;
            foreach (var item in arg)
            {
                sum += item;
            }
            avg = sum/(float)arg.Length;
            return sum;
        }

        public float SumDiv(ref float x, out float res, params int[] arg)
        {
            x = x > arg.Length ? x : arg.Length;
            res = Sum(arg)/x;
            return res;
        }

        public float Div(float x, float y=5)
        {
            return x/y;
        }
    }
}
