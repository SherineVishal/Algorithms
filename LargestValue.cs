using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class LargestValue
    {
        public static int findMax(int[] arr)
        {
            int max = int.MinValue;
            foreach(var item in arr)
            {
                if (item > max)
                    max = item;
            }
            return max;
        }
    }
}
