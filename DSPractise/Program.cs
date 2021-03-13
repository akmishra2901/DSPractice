using System;
using DSPractise.Node;
using DSPractise.Array;

namespace DSPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = { -2, -3, 4, -1, -2, 1, 5, -3 };
            Console.WriteLine(inputArr.ReturnLargestContiguousSum());
            Console.Read();
        }
    }
}
