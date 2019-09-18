using System;
using System.Linq;

namespace Algorithms.Solutions
{
    public static class SeekClosestToAverage
    {
        public static int GetClosestToAverage(int[] integers)
        {
            if (integers == null)
                throw new ArgumentNullException(nameof(integers));
            
            if (integers.Length == 0)
                throw new ArgumentException("Input array is empty");

            var sum = integers.Sum();
            var average = (decimal) sum / integers.Length;

            var closestInteger = integers[0];
            var minDifference = Math.Abs(average - closestInteger);
            
            for (int i = 1; i < integers.Length; i++)
            {
                var integer = integers[i];
                var difference = Math.Abs(average - integer);
                
                if (difference < minDifference)
                {
                    closestInteger = integer;
                    minDifference = difference;
                }
            }

            return closestInteger;
        }
    }
}