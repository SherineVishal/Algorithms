using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class ReverseWordsInString
    {
        public static void reverse(string str)
        {
            string[] words = str.Split(" ");
            foreach(var word in words)
            {
                char[] charArray = word.ToCharArray();
                int len = charArray.Length - 1;
                for(int i=0;i< charArray.Length/2;i++)
                {
                    char temp = charArray[i];
                    charArray[i] = charArray[len];
                    charArray[len] = temp;
                    len--;
                }

                Console.Write(new string(charArray)+ " ");
            }           

        }
    }
}
