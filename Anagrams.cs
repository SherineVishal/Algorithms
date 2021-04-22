using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Anagrams
    {
        public static void isAnagram(string str1,string str2)

        {

            if (str1.Length == 0 || str2.Length == 0)
                return;
            if(str1.Length!=str2.Length)
            {
                Console.WriteLine("It is an anagram");
                return;
            }
            int[] arr = new int[256];

            foreach(var item in str1)
            {
                arr[item]++;
            }

            foreach(var item in str2)
            {
                arr[item]--;
            }

            foreach(var item in arr)
            {
                if(item!=0)
                {
                    Console.WriteLine("Not an anagram");
                    return;
                }
            }
            Console.WriteLine("It is an anagram");
        }
    }
}
