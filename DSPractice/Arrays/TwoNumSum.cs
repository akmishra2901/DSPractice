using System;
using System.Collections.Generic;
using System.Text;

namespace DSPractice.Arrays
{
    public static class TwoNumSum
    {
        public static int[] GetTwoNumbersPositionWhichHaveTargetSum(this int[] nums, int target) {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    result[0] = dic[nums[i]];
                    result[1] = i;
                }
                else
                {
                    dic.Add(target - nums[i], i);
                }
            }
            return result;
        }
    }
}
