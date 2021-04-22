using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class SegregatePositiveNegative
    {
        public static void segregatePositiveNegative(int[] arr)
        {
            //    int start = 0;
            //    int end = arr.Length-1;
            //    while(start<end)
            //    {
            //        if(arr[start]>0)
            //        {
            //            swap(arr,start,end);
            //            end--;
            //        }
            //        else
            //            start++;
            //    }

            int end = arr.Length-1;
            int start = 0;
            while(start<end)
            {
                if (arr[start] > 0)
                {
                    swap(arr, start, end);
                    end--;
                }
                else
                    start++;
            }
            
        }

        public static void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }


    }
}
