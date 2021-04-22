using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class ReverseOrderOfWords
    {
        public static void reverse(string str)
        {
            //Method 1
            //string[] words = str.Split(" ");

            //StringBuilder builder = new StringBuilder();
            //for (int i=words.Length-1;i>=0;i--)
            //{
            //    builder.Append(words[i]);
            //    builder.Append(" ");
            //}

            //Console.WriteLine(builder.ToString());

            //Method 2
            //    char[] charArray = str.ToCharArray();

            //    int start = 0;

            //    for(int end=0;end<charArray.Length;end++)
            //    {
            //        if(charArray[end]==' ')
            //        {
            //            rev(charArray, start, end);
            //            start = end + 1;
            //        }
            //    }

            //    rev(charArray, start, charArray.Length-1);

            //    rev(charArray, 0, charArray.Length - 1);

            //    foreach (var item in charArray)
            //        Console.Write(item);
            //}

            

            char[] charArray = str.ToCharArray();

            int start = 0;
            
            for(int end=0;end<str.Length;end++)
            {
                if(charArray[end]==' ')
                {
                    rev(charArray, start, end);
                    start += end;
                }
            }

            rev(charArray, start, charArray.Length-1);

            rev(charArray, 0, charArray.Length - 1);
        }

        public static void rev(char[] charArray, int start, int end)
        {
            while (start <= end)
            {
                char temp = charArray[start];
                charArray[start] = charArray[end];
                charArray[end] = temp;
                start++;
                end--;
            }
        }
    }
}
