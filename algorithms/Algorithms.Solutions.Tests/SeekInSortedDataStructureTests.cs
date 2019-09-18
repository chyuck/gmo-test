using NUnit.Framework;

namespace Algorithms.Solutions.Tests
{
    [TestFixture]
    public class SeekInSortedDataStructureTests
    {
        private static readonly int[][] _matrix =
        {
            new[] {4,7,12,23,27,34},
            new[] {6,10,15,24,30,40},
            new[] {12,15,18,29,32,48},
            new[] {14,18,21,30,35,54},
            new[] {20,23,24,35,37,62},
            new[] {22,27,29,39,40,68},
            new[] {28,32,33,44,46,76},
            new[] {30,36,38,48,49,82}
        };
        
        [Test]
        [TestCase(18, ExpectedResult = true)]
        [TestCase(26, ExpectedResult = false)]
        [TestCase(4, ExpectedResult = true)]
        [TestCase(30, ExpectedResult = true)]
        [TestCase(82, ExpectedResult = true)]
        [TestCase(34, ExpectedResult = true)]
        [TestCase(14, ExpectedResult = true)]
        [TestCase(23, ExpectedResult = true)]
        [TestCase(62, ExpectedResult = true)]
        [TestCase(38, ExpectedResult = true)]
        [TestCase(100, ExpectedResult = false)]
        [TestCase(35, ExpectedResult = true)]
        public bool Test_DoesNumberExist(int target) => SeekInSortedDataStructure.DoesNumberExist(_matrix, target);
    }
}