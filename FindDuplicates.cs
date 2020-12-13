using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class FindDuplicates
    {
        public static void find(int[] arr)
        {
            Dictionary<int, int> keyValues = new Dictionary<int, int>();
            
            foreach(var item in arr)
            {
                if (!keyValues.ContainsKey(item))
                    keyValues[item] = 1;
                else
                    keyValues[item]++;
            }

            foreach (var item in keyValues)
            {
                if (item.Value > 1)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
