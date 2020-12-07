using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class FindSingleInSortedArray
    {
        //Binary search based
        public static void findSingle(int[] arr,int low,int high)
        {
            if (low > high)
            {
                Console.WriteLine("No such element");
                return;
            }

            if (low == high)
            {
                Console.WriteLine("The single element is {0}", arr[low]);
                return;
            }
           
           int mid = (low + high) / 2;
            // If mid is even and element
            // next to mid is same as mid
            // then output element lies on
            // right side, else on left side
            if (mid % 2 == 0)
           {
                if (arr[mid] == arr[mid + 1])
                    findSingle(arr, mid + 2, high);
                else
                    findSingle(arr, low, mid);
           }
           else if(mid%2 ==1)
           {
                if (arr[mid] == arr[mid - 1])
                    findSingle(arr, mid+1, high);
                else
                   findSingle(arr, low, mid-1);
           }
            
        }
    }
}
