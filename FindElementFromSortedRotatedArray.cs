using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algorithms
{
    class FindElementFromSortedRotatedArray
    {
        //split the array to 2 sorted arrays
        public static void splitAndFind(int[] arr,int item)
        {
            int maxIndex=Array.IndexOf(arr,arr.Max());
            if (maxIndex == arr.Length - 1)
                BinarySearch(arr, 0, arr.Length - 1,item);
            else if (item >= arr[0])
                BinarySearch(arr, 0, maxIndex,item);
            else
                BinarySearch(arr, maxIndex + 1, arr.Length - 1,item);
        }

        //Binary search
        public static void BinarySearch(int[] arr,int low,int high,int item)
        {
            if (low > high)
            {
                Console.WriteLine("No such element");
                return;
            }
            int mid = (low + high) / 2;
            if(arr[mid]==item)
            {
                Console.WriteLine("The item index : {0}",mid);
                return;
            }

            if (arr[mid] > item)
                BinarySearch(arr, low, mid - 1, item);
            else
                BinarySearch(arr, mid + 1, high, item);
        }
    }
}
