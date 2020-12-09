using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Leaders
    {
        public static void printLeaders(int[] arr)
        {
            List<int> leaders = new List<int>();
            int rSum = 0;
            for(int i=arr.Length-1;i>=0;i--)
            {
                if (arr[i] > rSum)
                    leaders.Add(arr[i]);
                rSum += arr[i];
            }
            foreach (var item in leaders)
                Console.WriteLine(item);
        }
    }
}
