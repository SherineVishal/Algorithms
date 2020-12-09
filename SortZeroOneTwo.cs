using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class SortZeroOneTwo
    {
        public static void Sort012(int[] arr)
        {
            /*Method I */
            /* 
            * int zCount = 0;
           int oCount = 0;
           int tCount = 0;
           foreach(var item in arr)
           {
               if (item == 0)
                   zCount++;
               else if (item == 1)
                   oCount++;
               else if (item == 2)
                   tCount++;
           }
           int j = 0;
           while (zCount > 0)
           {
               arr[j++] = 0;
               zCount--;
           }
           while (oCount > 0)
           {
               arr[j++] = 1;
               oCount--;
           }
           while (tCount > 0)
           {
               arr[j++] = 2;
               tCount--;
           }

           foreach (var item in arr)
               Console.WriteLine(item);

           */

            /* Method II - Dutch Flag*/

            int low = 0, mid = 0, high = arr.Length - 1;
            int temp;

            while(mid<=high)
            {
                switch(arr[mid])
                {
                    case 0:
                        temp = arr[mid];
                        arr[mid] = arr[low];
                        arr[low] = temp;
                        low++;
                        mid++;
                        break;
                    case 1:
                        mid++;
                        break;
                    case 2:
                        temp = arr[mid];
                        arr[mid] = arr[high];
                        arr[high] = temp;
                        high--;
                        break;
                }
            }

            foreach (var item in arr)
                Console.WriteLine(item);
        }
    }
}
