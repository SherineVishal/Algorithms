using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class FindDuplicateNumberInFirstN
    {
        //sum of first n elements will be (n * (n+1))/2
        public static void findDuplicate(int[] arr)
        {
            int n = arr.Length - 1;
            int sumN = (n * (n + 1)) / 2;
            int sum = 0;
            foreach (var item in arr)
                sum += item;
            int duplicate = sum-sumN ;
            Console.WriteLine(duplicate);
        }
    }
}
