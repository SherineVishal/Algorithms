using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    //sum of first n elements will be (n * (n+1))/2
    class FindMissingNumberInFirstN
    {
       public static void findMissing(int[] arr)
        {
            int n = arr.Length+1;
            int sumN =( n * (n + 1) )/ 2;
            int sum=0;
            foreach (var item in arr)
                sum += item;
            int missingNumber = sumN - sum;
            Console.WriteLine("The missing number is {0}", missingNumber);

        }
    }
}
