using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class MaxRepeatedChars
    {
        public static void maxRepeatedChars(string str)
        {



            //int count = 1;
            //int maxCount = 0;
            //int maxIndex=-1;
            //for(int i=0;i<str.Length-1;i++)
            //{
            //    if (str[i] == str[i + 1])
            //        count++;
            //    else
            //    {
            //        if(count>maxCount)
            //        {
            //            maxCount = count;
            //            maxIndex = i;                        
            //        }
            //        count = 1;
            //    }
            //}            

            //Console.WriteLine(str[maxIndex]);


            int count = 1;
            int maxCount = 0;
            int index = -1; ;
            for(int i=0;i<str.Length-1;i++)
            {
                if (str[i] == str[i + 1])
                {
                    count++;
                }
                else
                {
                    if(count>maxCount)
                    {
                        maxCount = count;
                        index = i;
                    }
                    count = 1;
                }
            }

            Console.WriteLine(str[index]);
            
        }

    }
}
