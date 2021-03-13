using System;
using System.Collections.Generic;
using System.Text;

namespace DSPractise.Array
{
    public static class LargestSumContiguousSubarray
    {
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
