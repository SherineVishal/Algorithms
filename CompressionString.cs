using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class CompressionString
    {
        public static void compress(string str)
        {
            string compressedString = str[0].ToString();
            int count = 1;
            for(int i=1;i<str.Length;i++)
            {
                if (str[i] == str[i - 1])
                    count++;
                else
                {
                    compressedString = compressedString+count;
                    count = 1;
                    if(i!=str.Length-1)
                        compressedString = compressedString + str[i];
                }
            }
            compressedString = compressedString + count;
            Console.WriteLine(compressedString);
        }
    }
}
