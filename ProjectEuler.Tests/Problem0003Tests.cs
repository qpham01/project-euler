using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    class Problem0003Tests
    {
        [TestCase(new long[] {2, 3, 5, 7, 11, 13, 23}, new [] {true, true, true, true, true, true, true})]
        [TestCase(new long[] { 0, 1, 4, 6, 8, 9, 10, 12, 14, 15 }, new[] { false, false, false, false, false, false, false, false, false, false })]
        [TestCase(new long[] { 600851475143 }, new[] { false })]
        public void TestIsPrime(long[] values, bool[] expected)
        {
            Assert.AreEqual(values.Length, expected.Length);
            for (var i = 0; i < values.Length; ++i)
            {
                var value = values[i];
                var result = Problem0003.IsPrime(value);
                Assert.AreEqual(expected[i], result);
            }
        }

        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(14, 7)]
        [TestCase(33, 11)]
        [TestCase(49, 7)]
        [TestCase(101, 101)]
        [TestCase(600851475143, 6857)]
        public void TestLargestPrimeFactor(long value, long expected)
        {
            var result = Problem0003.LargestPrimeFactor(value);
            Assert.AreEqual(expected, result);
        }
    }
}
