using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Segregate01
    {
        public static void segregate01(int[] arr)
        {
            //int start = 0;
            //int end = arr.Length-1;
            //while(start<end)
            //{
            //    if (arr[start] == 1)
            //    {
            //        swap(arr, start, end);
            //        end--;
            //    }
            //    else
            //        start++;
            //}


            //int start = 0;
            //int end = arr.Length - 1;

            //while(start<end)
            //{
            //    if (arr[start] == 1)
            //    {
            //        swap(arr, start, end);
            //        end--;
            //    }
            //    else
            //        start++;
            //}
        }

        public static void swap(int[] arr,int i,int j)
        {
            arr[i] = arr[i] + arr[j];
            arr[j] = arr[i] - arr[j];
            arr[i] = arr[i] - arr[j];
        }
    }
}
