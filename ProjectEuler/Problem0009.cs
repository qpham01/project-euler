using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ProjectEuler
{
    public class Problem0009
    {
        // Euclid's Formula: a = m^2 - n^2, b = 2mn, c = m^2 + n^2, where m > n;
        public static long ComputePythagoreanTripleSumProduct(int maxM, int sum)
        {
            for (var m = 2; m <= maxM; ++m)
            {
                for (var n = 1; n < m; ++n)
                {
                    var a = m * m - n * n;
                    var b = 2 * m * n;
                    var c = m * m + n * n;
                    if (a + b + c == sum)
                        return (long)a * b * c;
                }
            }
            return 0;
        }
    }
}
