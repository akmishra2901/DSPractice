using System;
using System.Collections.Generic;
using System.Text;

namespace DSPractice.Arrays
{
    public static class LargestSumContiguousSubarray
    {
        // Program to Get Largest Sum Contiguous Subarray from Input Array
        public static int ReturnLargestContiguousSum(this int[] inputArray) {
            int maxSum = int.MinValue;
            int maxSumEndingHere = 0;
            for (int i = 0; i < inputArray.Length; i++) {
                maxSumEndingHere = maxSumEndingHere + inputArray[i];

                if (maxSumEndingHere > maxSum)
                    maxSum = maxSumEndingHere;
                if (maxSumEndingHere < 0) {
                    maxSumEndingHere = 0;
                }
            }
            return maxSum;
        }
    }
}
