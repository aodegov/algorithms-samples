
using System;

namespace Algorithms.Searching
{
    public class BinarySearchAlgorithm
    {
        public int BinarySearch(int[] intArray, int valueToSearch)
        {
            var min = 0;
            var max = intArray.Length-1;
            while (min <= max)
            {
                var mid = (min + max) / 2;
                if(valueToSearch == intArray[mid])
                {
                    return mid;
                }
                else if(valueToSearch < intArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }


            // Not Found
            return -1;
        }

        // Start values min = 0, max = intArray.Lenght -1
        public int BinarySearchRecursion(int[] intArray, int valueToSearch, int min, int max)
        {
            if (min > max)
            {
                // Not Found
                return -1;
            }
            else
            {
                var mid = (min + max) / 2;
                if(valueToSearch == intArray[mid])
                {
                    return mid;
                }
                else if(valueToSearch < intArray[mid])
                {
                    return BinarySearchRecursion(intArray, valueToSearch, min, mid - 1);
                }
                else
                {
                    return BinarySearchRecursion(intArray, valueToSearch, mid + 1, max);
                }
            }
        }
    }
}
