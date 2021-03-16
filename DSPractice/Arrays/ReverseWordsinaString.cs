using System;
using System.Collections.Generic;
using System.Text;

namespace DSPractice.Arrays
{
    public static class ReverseWordsinaString
    {
        /*   Reverse Words in a String
         *   Given an input string s, reverse the order of the words.
         *   A word is defined as a sequence of non-space characters. 
         *   The words in s will be separated by at least one space.
         *   Return a string of the words in reverse order concatenated by a single space.
         *   Driver Code
         *   string input = "Alice does not even like bob";
         *   Console.WriteLine(input.GetReversedWordsofGivenString());
         *   Console.Read();
         */
        public static string GetReversedWordsofGivenString(this string inputStr) {
            string retval = string.Empty;
            string output = string.Empty;
            for (int i = inputStr.Length-1; i >= 0; i--) {
                if (inputStr.Substring(i, 1) == " " || i == 0) {
                    retval = ((retval).Trim() + " " + (inputStr.Substring(i, 1) + output).Trim()).Trim();
                    output = string.Empty;
                }
                else
                    output = inputStr.Substring(i, 1) + output;
            }
            return retval.Trim();
        }
    }
}
