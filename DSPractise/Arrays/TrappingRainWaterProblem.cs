using System;
using System.Collections.Generic;
using System.Text;

namespace DSPractise.Arrays
{
    public static class TrappingRainWaterProblem
    {
        /* Given n non-negative integers representing an elevation map where the width 
        of each bar is 1, compute how much water it can trap after raining.
        Input: height = [0,1,0,2,1,0,1,3,2,1,2,1]
        Output: 6*/
        public static int ReturnTrappingRainWaterProblemResult(this int[] height) 
        {
            int retval = 0;
            for (int i = 0; i < height.Length; i++)
            {
                int rightMax = height[i];
                int leftMax = height[i];
                int pos = i;
                while (pos >= 0)
                {
                    if (height[pos] > leftMax)
                    {
                        leftMax = height[pos];
                    }
                    pos--;
                }
                pos = i;
                while (pos < height.Length)
                {
                    if (height[pos] > rightMax)
                    {
                        rightMax = height[pos];
                    }
                    pos++;
                }
                retval = retval + (Math.Min(rightMax, leftMax) - height[i]);
            }
            return retval;
        }
    }
}
