using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DSPractice.Arrays
{
    public static class MergeIntervalsInArray
    {
        /* Merge Overlapping Intervals in an Array
         * Drive Code
         * int[][] inputArr = new int[4][]{new int[] { 1, 3 }, new int[] { 2, 6 }, new int[] { 8, 10 }, new int[] { 15, 18 }};
            int[][] result = inputArr.ReturnMergeIntervalsInArray();
            foreach (var v in result) {
                Console.WriteLine(v[0].ToString()+","+v[1].ToString());
            }
            Console.Read();
         */
        public static int[][] ReturnMergeIntervalsInArray(this int[][] inputArray) {
            List<int[]> retArr = new List<int[]>();
            if (inputArray.Length == 1)
                return inputArray;
            for (int i = 1; i < inputArray.Length; i++) {
                if (inputArray[i][0] <= inputArray[i - 1][1])
                {
                    retArr.Add(new int[] { inputArray[i - 1][0], inputArray[i][1] });
                }
                else {
                    retArr.Add(new int[] { inputArray[i][0], inputArray[i][1] });
                }
            }
            return retArr.ToArray();
        }
    }
}
