using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class FindNegative
    {
        public static void findNegative(int[] arr)
        {
            List<int> nArray = new List<int>();
            foreach(var item in arr)
            {
                if (item < 0)
                    nArray.Add(item);
            }
            foreach (var item in nArray)
                Console.WriteLine(item);
        }
    }
}
