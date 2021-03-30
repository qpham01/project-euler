using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace ProjectEuler
{
    public class Problem0004
    {
        public static int LargestPalindromeProduct(int max)
        {
            var largest = int.MinValue;
            for (var i = max; i > 0; i--)
            {
                for (var j = max; j > 0; j--)
                {
                    var product = i * j;
                    var value = product.ToString();
                    var halfLength = value.Length / 2 + value.Length % 2;
                    var left = value.Substring(0, halfLength);
                    var right = value.Substring(value.Length - halfLength, halfLength).ToCharArray();
                    var reversed = new string(right.Reverse().ToArray());
                    if (left == reversed && product > largest)
                    {
                        largest = product;
                    }
                }
            }

            return largest;
        }
    }
}
