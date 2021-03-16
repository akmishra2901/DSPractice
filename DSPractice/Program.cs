using System;
using DSPractice.Node;
using DSPractice.Arrays;
using System.Collections.Generic;
namespace DSPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] inputArr = new int[4][]{new int[] { 1, 3 }, new int[] { 2, 6 }, new int[] { 8, 10 }, new int[] { 15, 18 }};
            int[][] result = inputArr.ReturnMergeIntervalsInArray();
            foreach (var v in result) {
                Console.WriteLine(v[0].ToString()+","+v[1].ToString());
            }
            Console.Read();
        }
    }
}
