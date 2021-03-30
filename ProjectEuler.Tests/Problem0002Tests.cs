using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    class Problem0002Tests
    {
        [TestCase(12, 10)]
        [TestCase(33, 10)]
        [TestCase(34, 44)]
        [TestCase(4000000, 4613732)]
        public void TestProblem0002(int limit, int expected)
        {
            var result = Problem0002.SumEvenFibonacci(limit);
            Assert.AreEqual(expected, result);
        }
    }
}
