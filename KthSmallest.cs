using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class KthSmallest
    {
        public static void findKthSmallest(int[] arr,int low,int high,int k)
        {
            if (k>0 && k<=high-low+1)
            {
                int partitionIndex = partition(arr, low, high);

                if (partitionIndex == k - 1)
                {
                    Console.WriteLine("The {0}th smallest element is {1}", k, arr[partitionIndex]);
                    return;
                }

                findKthSmallest(arr, low, partitionIndex - 1, k);
                findKthSmallest(arr, partitionIndex + 1, high, k);
            }
        }

        public static int partition(int[] arr,int low,int high)
        {
            int lastIndexOfsmallerElements = low - 1;
            int elementToPosition = arr[high];

            int temp;
            for(int i=low;i<high;i++)
            {
                if(arr[i]< elementToPosition)
                {
                    lastIndexOfsmallerElements++;
                    temp = arr[lastIndexOfsmallerElements];
                    arr[lastIndexOfsmallerElements] = arr[i];
                    arr[i] = temp;
                }
            }
            temp = arr[lastIndexOfsmallerElements+1];
            arr[lastIndexOfsmallerElements+1] = arr[high];
            arr[high] = temp;
            return (lastIndexOfsmallerElements + 1);
        }
    }
}
