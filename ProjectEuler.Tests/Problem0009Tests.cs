using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    class Problem0009Tests
    {
        [TestCase(4, 12, 60)]
        [TestCase(30, 70, 12180)]
        [TestCase(300, 1000, 31875000)]
        public void TestComputePythagoreanTripleSumProduct(int maxM, int sum, long expected)
        {
            var result = Problem0009.ComputePythagoreanTripleSumProduct(maxM, sum);
            Assert.AreEqual(expected, result);
        }
    }
}
