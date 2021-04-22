using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class MostFrequentNumberInAnArray
    {
        public static void findMostFrequent(int[] arr)
        {
            //Method 1
            //Dictionary<int, int> keyValue = new Dictionary<int, int>();

            //foreach(var item in arr)
            //{
            //    if (keyValue.ContainsKey(item))
            //        keyValue[item]++;
            //    else
            //        keyValue[item] = 1;
            //}

            //int maxCount = 0;
            //int mostRep = new int();
            //foreach(var item in keyValue)
            //{
            //    if(item.Value>maxCount)
            //    {
            //        maxCount = item.Value;
            //        mostRep = item.Key;
            //    }
            //}

            //Console.WriteLine(mostRep);


            //Method 2

            int maxCount = 0;
            int maxElement = new int();
            for(int i=0;i<arr.Length;i++)
            {
                int count = 1;
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[i]==arr[j])
                    {
                        count++;
                    }
                }
                if (count > maxCount) 
                {
                    maxCount = count;
                    maxElement = arr[i];
                }
            }

            Console.WriteLine(maxElement);
        }
    }
}
