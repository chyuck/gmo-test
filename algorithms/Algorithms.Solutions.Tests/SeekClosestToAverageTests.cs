using NUnit.Framework;

namespace Algorithms.Solutions.Tests
{
    [TestFixture]
    public class SeekClosestToAverageTests
    {
        [Test]
        [TestCase(new[] { 3 }, ExpectedResult = 3)]
        [TestCase(new[] { 3 , 5 }, ExpectedResult = 3)]
        [TestCase(new[] { 3, 4 }, ExpectedResult = 3)]
        [TestCase(new[] { 1, 2, 3 }, ExpectedResult = 2)]
        [TestCase(new[] { -1, 2, -2, 2 }, ExpectedResult = -1)]
        [TestCase(new[] { -13, -22, 7, 15, 30, 2 }, ExpectedResult = 2)]
        [TestCase(new[] { 1, 2, 3, 5, -1, 7, 145, -33, 22, 14 }, ExpectedResult = 14)]
        public int Test_GetClosestToAverage(int[] integers) => SeekClosestToAverage.GetClosestToAverage(integers);
    }
}