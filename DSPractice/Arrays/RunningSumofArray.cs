using System;
using System.Collections.Generic;
using System.Text;

namespace DSPractice.Arrays
{
    public static class RunningSumofArray
    {
        public static int[] RunningSum(this int[] nums)
        {
            if (nums.Length <= 1)
            {
                return nums;
            }
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] = nums[i - 1] + nums[i];
            }
            return nums;
        }
    }
}
