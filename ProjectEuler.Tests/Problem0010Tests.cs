using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    class Problem0010Tests
    {
        [TestCase(10, 17)]
        [TestCase(20, 77)]
        [TestCase(2000000, 142913828922)]
        public void TestSumAllPrimesBelowLimit(long limit, long expected)
        {
            var result = Problem0010.SumAllPrimesBelowLimit(limit);
            Assert.AreEqual(expected, result);
        }
    }
}
