using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    class Problem0004Tests
    {
        [TestCase(99, 9009)]
        [TestCase(999, 906609)]
        public void TestLargestPalindromeProduct(int max, int expected)
        {
            var result = Problem0004.LargestPalindromeProduct(max);
            Assert.AreEqual(expected, result);
        }
    }
}
