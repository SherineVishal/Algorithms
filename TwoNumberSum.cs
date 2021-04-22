using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class TwoNumberSum
    {
        public static void find2Sum(int[] arr, int k)
        {
            //Method 1
            //for(int i=0;i<arr.Length;i++)
            //{
            //    for(int j=i+1;j<arr.Length;j++)
            //    {
            //        if(arr[i]+arr[j]==k)
            //        {
            //            Console.WriteLine(arr[i] + " " +arr[j]);
            //            return;
            //        }
            //    }
            //}
            //Console.WriteLine("No such elements");

            //Method 2
            //    Array.Sort(arr);

            //    int start = 0;
            //    int end = start + 1;

            //    while(end<arr.Length && start<arr.Length)
            //    {
            //        if (arr[start] + arr[end] == k)
            //        {
            //            Console.WriteLine(arr[start] + " " + arr[end]);
            //            return;
            //        }
            //        else if (arr[start] + arr[end] < k)
            //        {
            //            end++;
            //        }
            //        else
            //            start++;
            //    }

            //    Console.WriteLine("No such element exist");
            //}

            //Method 3

            HashSet<int> hs = new HashSet<int>();
            

            foreach (var item in arr)
            {
                int target = k - item;
                if (hs.Contains(target))
                {
                    Console.WriteLine(item + " " + target);
                    return;
                }
                hs.Add(item);
            }
        }
    }
}
