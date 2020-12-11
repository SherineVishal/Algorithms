using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class StringAllUniqueChar
    {
        public static void isUnique(string str)
        {
            if (str.Length == 0)
                return;

            //using additional memory

            /*Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach(var item in str)
            {
                if (item == ' ')
                    continue;
                if (!dict.ContainsKey(item))
                    dict.Add(item, 1);
                else
                {
                    Console.WriteLine("Contains duplicates");
                    return;
                }
            }
            Console.WriteLine("Conatins all unique characters");*/

            //Brute force

            /*
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i]!=' ' && str[i] == str[j])
                    {
                        Console.WriteLine("Contains duplicate");
                        return;
                    }
                }
            }
            Console.WriteLine("Contains all unique characters");
            */

            //Sorting

            /*
            char[] charArray = str.ToCharArray();
            Array.Sort(charArray);
            for(int i=0;i<charArray.Length-1;i++)
            {
                if(charArray[i]==charArray[i+1])
                {
                    Console.WriteLine("Contain duplicates");
                    return;
                }    
            }
            Console.WriteLine("All unique");

            */
            //using bool array

            bool[] chars = new bool[256];
            if (str.Length > 256)
            {
                Console.WriteLine("Contains duplicate");
                return;
            }
            for (int i = 0; i < chars.Length; i++)
                chars[i] = false;

            for(int i=0;i<str.Length;i++)
            {
                if (str[i] == ' ')
                    continue;
                int index = (int)str[i];
                if (chars[index] == true)
                {
                    Console.WriteLine("Contains duplicate");
                    return;
                }
                else
                    chars[index] = true;
            }
            Console.WriteLine("All Unique");
        }
    }
}
