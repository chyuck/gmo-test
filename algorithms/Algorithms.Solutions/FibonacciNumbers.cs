using System;
using System.Numerics;

namespace Algorithms.Solutions
{
    public static class FibonacciNumbers
    {
        public static BigInteger GetValueByIndex(int index)
        {
            if (index < 1) 
                throw new ArgumentException("Index must be greater than 0");

            if (index <= 1) 
                return index;

            if (index == 2)
                return 1;

            BigInteger current = 0, prev1 = 1, prev2 = 1;

            for (var i = 3; i <= index; i++)
            {
                current = prev1 + prev2;
                prev2 = prev1;
                prev1 = current;
            }

            return current;
        }
    }
}