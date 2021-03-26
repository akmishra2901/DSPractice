using System;
using System.Collections.Generic;
using System.Text;

namespace DSPractice.Arrays
{
    public static class KidsWithMaximumNumofCandies
    {
        /* Given the array candies and the integer extraCandies, where candies[i] 
        represents the number of candies that the ith kid has.
        For each kid check if there is a way to distribute extraCandies among the kids 
        such that he or she can have the greatest number of candies among them.Notice that
        multiple kids can have the greatest number of candies.*/
        public static IList<bool> KidsWithCandies(this int[] candies, int extraCandies)
        {
            int max = int.MinValue;
            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] > max)
                {
                    max = candies[i];
                }
            }
            IList<bool> result = new List<bool>();
            for (int i = 0; i < candies.Length; i++)
            {
                if ((candies[i] + extraCandies) < max)
                {
                    result.Add(false);
                }
                else
                {
                    result.Add(true);
                }
            }
            return result;
        }
    }
}
