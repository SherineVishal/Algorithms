using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class FindNegative
    {
        public static void findNegative(int[] arr)
        {
            //Using extra space

            List<int> nArray = new List<int>();
            foreach(var item in arr)
            {
                if (item < 0)
                    nArray.Add(item);
            }
            foreach (var item in nArray)
                Console.WriteLine(item);

            //Method 2

            for(int i=0;i<arr.Length;i++)
            {
                int count = 0;
                for(int j=i+1;j<arr.Length;j++)
                {

                }
            }
        }
    }
}
