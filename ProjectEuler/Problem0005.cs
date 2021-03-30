using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public class Problem0005
    {
        public static int[] PrimesUnderValue(int value)
        {
            var primes = new List<int>();
            for (var i = 2; i <= value; ++i)
            {
                if (Problem0003.IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            return primes.ToArray();
        }
        public static long SmallestDividedBy1To10()
        {
            var product = 2L * 3 * 4 * 5 * 7 * 3;
            return product;
        }

        public static long SmallestDividedBy1To20()
        {
            var product = 2L * 3 * 4 * 5 * 7 * 3 * 11 * 13 * 2 * 17 * 19;
            return product;
        }
    }
}
