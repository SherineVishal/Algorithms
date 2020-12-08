using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class SplitTheArray
    {
        // Add all the elements and find the difference between sum and the element.
        public static void split(int[] arr)
        {
            List<int> sumList = new List<int>();
            List<int> otherThanSumList = new List<int>();

            int sum = 0;
            foreach (var item in arr)
                sum += item;
            
            foreach (var item in arr)
            {
                if (item == (sum - item))
                    sumList.Add(item);
                else
                    otherThanSumList.Add(item);
            }

            Console.WriteLine("Sum list");
            foreach (var item in sumList)
                Console.WriteLine(item);
            Console.WriteLine("Elements other than the sum");
            foreach (var item in otherThanSumList)
                Console.WriteLine(item);

            
        }
    }
}
