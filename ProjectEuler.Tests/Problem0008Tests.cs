using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    class Problem0008Tests
    {
        [TestCase(4, 5832)]
        [TestCase(13, 23514624000)]
        public void TestLargestConsecutiveNumberProduct(int consecutiveCount, long expected)
        {
            var result = Problem0008.LargestConsecutiveNumberProduct(consecutiveCount);
            Assert.AreEqual(expected, result);
        }
    }
}
