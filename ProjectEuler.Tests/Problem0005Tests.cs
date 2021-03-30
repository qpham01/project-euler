using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    class Problem0005Tests
    {
        [TestCase(10, new[] {2, 3, 5, 7})]
        [TestCase(11, new[] { 2, 3, 5, 7, 11 })]
        public void TestPrimeUnderValue(int value, int[] expected)
        {
            var result = Problem0005.PrimesUnderValue(value);
            Assert.That(expected.SequenceEqual(result));
        }

        [Test]
        public void TestSmallestDividedBy1To10()
        {
            var result = Problem0005.SmallestDividedBy1To10();
            Assert.AreEqual(2520, result);
        }

        [Test]
        public void TestSmallestDividedBy1To20()
        {
            var result = Problem0005.SmallestDividedBy1To20();
            Assert.AreEqual(232792560, result);
        }
    }
}
