using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace DSPractise.Array
{
    // To Find 
    public static class ElementAppearMoreThanKTime
    {
        public static int[] GetElementAppearsMoreThanKTime(this int[] inputArray, int k) {
            List<int> retuval = new List<int>();
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            foreach (int item in inputArray) {
                if (keyValuePairs.ContainsKey(item))
                    keyValuePairs[item] = keyValuePairs[item] + 1;
                else
                    keyValuePairs.Add(item, 1);
            }
            foreach (var keyValue in keyValuePairs) {
                if (keyValue.Value > k)
                    retuval.Add(keyValue.Key);
            }
            return retuval.ToArray();
        }

    }
}
