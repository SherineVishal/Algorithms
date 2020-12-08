using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    //skip the search after Math.Abs(diff)
    class FindElementAdjacentDifferenceOne
    {
        public static void findElement(int[] arr,int item)
        {
            int diff = 0;
            for(int i=0;i<arr.Length;)
            {
                if (arr[i] == item)
                {
                    Console.WriteLine("{0} is located at index {1}", item, i);
                    return;
                }
                diff = Math.Abs(item-arr[i]);
                i+=diff;
            }
            Console.WriteLine("Element not present");
        }
    }
}
