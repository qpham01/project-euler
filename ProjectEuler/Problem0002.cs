using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ProjectEuler
{
    public class Problem0002
    {
        public static long SumEvenFibonacci(int limit)
        {
            long sum = 0;
            var prev = 1;
            var next = 2;
            while (next <= limit)
            {
                if (next % 2 == 0) sum += next;
                var temp = next;
                next = prev + temp;
                prev = temp;
            }

            return sum;
        }
    }
}
