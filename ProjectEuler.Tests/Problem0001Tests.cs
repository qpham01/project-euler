using NUnit.Framework;

namespace ProjectEuler.Tests
{
    public class Problem0001Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(10, 23)]
        [TestCase(1000, 233168)]
        public void TestProblem0001(int limit, int expected)
        {
            var result = Problem0001.MultiplesOf3and5(limit);
            Assert.AreEqual(expected, result);
        }
    }
}