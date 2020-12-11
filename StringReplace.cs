using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class StringReplace
    {
        public static void replace(char[] strArray)
        {
            
            int countSpace = 0;
            foreach (var item in strArray)
                if (item == ' ')
                    countSpace++;
            int actualLength = strArray.Length;
            int newLength = strArray.Length + countSpace * 2;
            Array.Resize(ref strArray, newLength);
            newLength--;
            for (int i= actualLength - 1;i>=0;i--)
            {
                if(strArray[i]==' ')
                {
                    strArray[newLength--] = '%';
                    strArray[newLength--] = '0';
                    strArray[newLength--] = '2';
                }
                else
                    strArray[newLength--] = strArray[i];
            }
            foreach (var item in strArray)
                Console.Write(item);
        }
    }
}
