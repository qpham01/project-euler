using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    class Problem0006Tests
    {
        [TestCase(1, 4, 30)]
        [TestCase(1, 10,385)]
        public void TestSumOfSquares(int min, int max, int expected)
        {
            var result = Problem0006.SumOfSquares(min, max);
            Assert.AreEqual(expected, result);
        }

        [TestCase(1, 10, 3025)]
        public void TestSquareOfSums(int min, int max, long expected)
        {
            var result = Problem0006.SquareOfSums(min, max);
            Assert.AreEqual(expected, result);
        }

        [TestCase(1, 10, 2640)]
        [TestCase(1, 100, 25164150)]
        public void TestSquareOfSumsMinusSumOfSquares(int min, int max, int expected)
        {
            var result = Problem0006.SquareOfSumsMinusSumOfSquares(min, max);
            Assert.AreEqual(expected, result);
        }

    }
}
