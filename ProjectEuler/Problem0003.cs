using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ProjectEuler
{
    public class Problem0003
    {

        public static bool IsPrime(long value)
        {
            if (value < 2) return false;
            if (value == 2 || value == 3) return true;
            var half = value / 2;
            for (var i = 2; i <= half; ++i)
            {
                if (value % i == 0) return false;
            }

            return true;
        }


        public static long LargestPrimeFactor(long value)
        {
            var half = value / 2;
            for (var i = 1; i <= half; ++i)
            {
                if (value % i == 0)
                {
                    var x = value / i;
                    if (IsPrime(x)) return x;
                }
            }

            return value;
        }
    }
}
