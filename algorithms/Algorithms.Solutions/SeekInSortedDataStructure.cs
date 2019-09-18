using System;

namespace Algorithms.Solutions
{
    public static class SeekInSortedDataStructure
    {
        public static bool DoesNumberExist(int[][] matrix, int target)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            if (matrix.Length == 0 || matrix[0].Length == 0)
                return false;

            var n = matrix.Length; 
            var m = matrix[0].Length;

            // IDEA: because structure is similar to BST with head in upper right corner
            // traverse matrix like BST
            // value at left is smaller, value at bottom is greater
            
            var row = 0;
            var col = m - 1;

            while (row < n && col >= 0)
            {
                var value = matrix[row][col];

                if (value == target)
                    return true;

                if (value > target)
                {
                    col--;
                    continue;
                }

                row++;
            }

            return false;
        }
    }
}