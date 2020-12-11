using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class StringPermutation
    {
        public static void isPermutation(string str1,string str2)
        {
            if(str1.Length!=str2.Length)
            {
                Console.WriteLine("It's not permuted strings");
                return;
            }
            int[] arr = new int[256];

            for(int i= 0;i<256;i++)
                arr[i] = 0;

            for(int i=0;i<str1.Length;i++)
            {
                arr[(int)str1[i]]++;
                arr[(int)str2[i]]--;
            }

            foreach (var item in arr)
            {
                if (item != 0)
                {
                    Console.WriteLine("It's not permuted strings");
                    return;
                }
            }
            Console.WriteLine("It is permuted string");
        }
    }
}
