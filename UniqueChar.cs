using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class UniqueChar
    {
        public static void isUnique(string str)
        {
            if (str.Length == 0)
                return;
            if(str.Length>256)
            {
                Console.WriteLine("Not unique");
                return;
            }
            int[] arr = new int[256];

            foreach(var item in str)
            {
                arr[item]++;
            }

            foreach(var item in arr)
            {
                if(item>1)
                {
                    Console.WriteLine("Its not unique");
                    return;
                }
            }
            Console.WriteLine("It's unique");

        }
    }
}
