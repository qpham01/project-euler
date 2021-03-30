using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public class Problem0007
    {
        public static long FindPrime(int order)
        {
            if (order == 1) return 2;
            var current = 1;
            var number = 3;
            while (true)
            {
                if (Problem0003.IsPrime(number))
                {
                    current++;
                    if (current == order) return number;
                }
                number += 2;
            }
        }
    }
}
