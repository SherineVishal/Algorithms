using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class ReverseString
    {
        public static void reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            int l = charArray.Length;
            int m = l / 2;
            l--;

            for (int i = 0; i < m; i++)
            {
                char temp = charArray[i];
                charArray[i] = charArray[l];
                charArray[l] = temp;
                l--;
            }


            Console.WriteLine(new string(charArray));
        }
    }
}
