using System;
using System.Collections.Generic;
using System.Text;

namespace DSPractice.Arrays
{
    public static class ReverseCharArray
    {
        public static char[] GetReversedCharArray(this char[] inputArr) {
            int start = 0;
            int end = inputArr.Length - 1;
            if (end == 0)
                return inputArr;
            while (start <= end) {
                char temp = inputArr[start];
                inputArr[start] = inputArr[end];
                inputArr[end] = temp;
            }
            return inputArr;
        }
    }
}
