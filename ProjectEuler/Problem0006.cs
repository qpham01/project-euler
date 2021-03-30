using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.SymbolStore;
using System.Text;

namespace ProjectEuler
{
    public class Problem0006
    {
        public static long SumOfSquares(int min, int max)
        {
            var sum = 0;
            for (var i = min; i <= max; ++i)
            {
                sum += i * i;
            }

            return sum;
        }

        public static long SquareOfSums(int min, int max)
        {
            var count = max - min + 1;
            var halfCount = count / 2;
            var half = halfCount + min;
            var add = (count % 2 == 1) ? half : 0;
            var sum = (max + min) * halfCount + add;
            return sum * sum;
        }

        public static long SquareOfSumsMinusSumOfSquares(int min, int max)
        {
            return SquareOfSums(min, max) - SumOfSquares(min, max);
        }
    }
}
