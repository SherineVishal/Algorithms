using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class MagicIndexInSortedArray
    {
        //Binary search
        public static void findMagicIndex(int[] arr,int low,int high)
        {
            if(low>high)
            {
                Console.WriteLine("No magic index");
                return;
            }

            int mid = (low + high) / 2;

            if(mid==arr[mid])
            {
                Console.WriteLine("Magic Index : {0}", mid);
                return;
            }

            if (arr[mid] < mid)
                findMagicIndex(arr, mid + 1, high);
            else
                findMagicIndex(arr, low, mid - 1);
        }
    }
}
