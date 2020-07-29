using System;
using Algorithms.Searching;

namespace Algorithms.Processor
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchAlgorithm binary = new BinarySearchAlgorithm();
            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var foundIndex = binary.BinarySearchRecursion(arr, 7, 0, arr.Length - 1);
            Console.WriteLine($"Index {(foundIndex == -1 ? "wasn't find" : $"is found: {foundIndex}")}");
            Console.ReadKey();
        }
    }
}
