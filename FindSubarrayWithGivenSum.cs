using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class FindSubarrayWithGivenSum
    {
        public static void findSubArray(int[] arr,int lookupSum)
        {
            int sum = 0;
            int startIndex = 0;
            
            
            for(int i=0;i<arr.Length;i++)
            {
                sum += arr[i];                

                while (sum>lookupSum && startIndex<i-1)
                {
                    ///int intSum = sum;
                    sum = sum - arr[startIndex];
                    startIndex++;
                }
                if (sum == lookupSum)
                {
                    Console.WriteLine("It's between the index {0} and {1}", startIndex, i-1);
                    return;
                }
            }
            Console.WriteLine("No such sub-Array");
            
        }
    }
}
