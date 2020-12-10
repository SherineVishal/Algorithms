using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class QuickSort
    {
        /*public static void quickSort(int[] arr,int low,int high)
        {
            if (low<high)
            {
                int partitionIndex = partition(arr,low,high);
                quickSort(arr, low, partitionIndex - 1);
                quickSort(arr, partitionIndex + 1, high);
            }

        }

        public static int partition(int[] arr, int low,int high)
        {
            int temp;
            int elementToPosition = arr[high];
            int lastSmallerElementIndex = low - 1;
            for(int currentElementIndex=low; currentElementIndex < high; currentElementIndex++)
            {
                if(arr[currentElementIndex] < elementToPosition)
                {
                    lastSmallerElementIndex++;
                    temp = arr[lastSmallerElementIndex];
                    arr[lastSmallerElementIndex] = arr[currentElementIndex];
                    arr[currentElementIndex] = temp;
                }
            }
            temp = arr[lastSmallerElementIndex + 1];
            arr[lastSmallerElementIndex + 1] = arr[high];
            arr[high] = temp;
            return (lastSmallerElementIndex + 1);
        }*/
    

        public static void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = partition(arr, low, high);
                quickSort(arr, low, partitionIndex - 1);
                quickSort(arr, partitionIndex + 1, high);
            }
        }

        public static int partition(int[] arr,int low,int high)
        {
            int temp;
            int endOfSmallerElementIndex = low - 1;
            int elementToPosition = arr[high];
            for(int currentIndex=low;currentIndex<high;currentIndex++)
            {
                if (arr[currentIndex] < elementToPosition)
                {
                    endOfSmallerElementIndex++;
                    temp = arr[endOfSmallerElementIndex];
                    arr[endOfSmallerElementIndex] = arr[currentIndex];
                    arr[currentIndex] = temp;
                }                
            }
            temp = arr[endOfSmallerElementIndex + 1];
            arr[endOfSmallerElementIndex + 1] = arr[high];
            arr[high] = temp;
            return (endOfSmallerElementIndex + 1);
        }
    }
}
