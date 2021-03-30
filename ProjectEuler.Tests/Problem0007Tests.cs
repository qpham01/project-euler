using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    class Problem0007Tests
    {
        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(3, 5)]
        [TestCase(6, 13)]
        [TestCase(10001, 104743)]
        public void TestFindPrime(int order, int expected)
        {
            var prime = Problem0007.FindPrime(order);
            Assert.AreEqual(expected, prime);
        }
    }
}
