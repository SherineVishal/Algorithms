using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class FindSubarrayWithGivenSumNegative
    {
        public static void findSubArray(int[] arr,int lookupSum)
        {
            Dictionary<int, int> sumIndexPair = new Dictionary<int, int>();
            int sum = 0;
            int startIndex = 0;
            for(int i=0;i<arr.Length;i++)
            {
                sum += arr[i];
                if(sum== lookupSum)
                {
                    Console.WriteLine("The sum is between {0} and {1}",startIndex,i);
                    return;
                }
                if (sumIndexPair.ContainsKey(sum - lookupSum))
                {
                    startIndex = sumIndexPair[sum - lookupSum] + 1;
                    Console.WriteLine("The sum is between {0} and {1}", startIndex, i);
                    return;
                }
                else
                    sumIndexPair[sum]=i;
            }
            Console.WriteLine("Sum not present");
        }
    }
}
