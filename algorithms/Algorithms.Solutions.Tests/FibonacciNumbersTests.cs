using NUnit.Framework;

namespace Algorithms.Solutions.Tests
{
    [TestFixture]
    public class FibonacciNumbersTests
    {
        [Test]
        [TestCase(1, ExpectedResult = "1")]
        [TestCase(2, ExpectedResult = "1")]
        [TestCase(3, ExpectedResult = "2")]
        [TestCase(4, ExpectedResult = "3")]
        [TestCase(5, ExpectedResult = "5")]
        [TestCase(100, ExpectedResult = "354224848179261915075")]
        public string Test_GetValueByIndex(int index)
        {
            var result = FibonacciNumbers.GetValueByIndex(index);

            return result.ToString();
        }
    }
}