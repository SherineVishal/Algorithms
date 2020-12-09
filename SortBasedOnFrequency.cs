using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    class SortBasedOnFrequency
    {
        public static void sort(int[] arr)
        {
            Dictionary<int, int> numberFequencyPair = new Dictionary<int, int>();
            foreach(var item in arr)
            {
                if (!numberFequencyPair.ContainsKey(item))
                    numberFequencyPair[item]=1;
                else
                    numberFequencyPair[item]++;

            }

            numberFequencyPair = numberFequencyPair.OrderByDescending(x => x.Value).
                ToDictionary(x => x.Key, y => y.Value);

            foreach (var item in numberFequencyPair)
            {
                int count = item.Value;
                while (count > 0)
                {
                    Console.Write("{0} ,", item.Key);
                    count--;
                }
            }
        }
    }
}
