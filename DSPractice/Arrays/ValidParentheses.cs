using System;
using System.Collections.Generic;
using System.Text;

namespace DSPractice.Arrays
{
    public static class ValidParentheses
    {
        /*  Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', 
         *  determine if the input string is valid.
         *  string inputArr = "(((((())))))";
            bool result = inputArr.CheckValidParentheses();
            Console.WriteLine(result);
         */
        public static bool CheckValidParentheses(this string inputStr) {
            char[] strArr = inputStr.ToCharArray();
            Dictionary<char, char> keyValuePairs = new Dictionary<char, char>();
            keyValuePairs.Add(']', '[');
            keyValuePairs.Add('}', '{');
            keyValuePairs.Add(')', '(');
            Stack<char> charStack = new Stack<char>();
            for (int i = 0; i < strArr.Length; i++) {
                char item = strArr[i];
                if (keyValuePairs.ContainsKey(item))
                {
                    char popItem = charStack.Count > 0 ?  charStack.Pop() : '#';
                    if (keyValuePairs[item] != popItem)
                        return false;
                }
                else 
                {
                    charStack.Push(item);
                }
            }
            return charStack.Count == 0;
        }
    }
}
