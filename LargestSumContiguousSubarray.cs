using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class LargestSumContiguousSubarray
    {
        public static void largestSum(int[] arr)
        {
            int maxGlobalSum = int.MinValue;
            int maxLocalSum = 0;
            int startIndex = 0;
            int endIndex = 0;
            

            for(int i=0;i<arr.Length;i++)
            {
                maxLocalSum+=arr[i];
                if (arr[i] > maxLocalSum)
                {
                    startIndex = i;
                    endIndex = i;
                    maxLocalSum = arr[i];
                }
                if(maxLocalSum > maxGlobalSum)
                {
                    endIndex = i;
                    maxGlobalSum = maxLocalSum;
                }
            }

            Console.WriteLine("The largest sum of the contiguous sub array is {0} and that is between the index {1} and {2}", 
                maxGlobalSum, startIndex, endIndex);

        }
    }
}
