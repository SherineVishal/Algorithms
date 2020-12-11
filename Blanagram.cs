using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Blanagram
    {
        public static void isPermutation(string str1,string str2)
        {
            if(str1.Length!=str2.Length)
            {
                Console.WriteLine("Not a blanagram");
                return;
            }

            int[] arr = new int[256];
            int count1=0, count2=0, count = 0;

            for (int i = 0; i < 256; i++)
                arr[i] = 0;
            for(int i=0;i<str1.Length;i++)
            {
                arr[(int)str1[i]]++;
                arr[(int)str2[i]]--;
            }
            
            for(int i=0;i<256;i++)
            {
                if (arr[i] != 0 && count==0)
                {
                    count1 = arr[i];
                    count++;
                }
                else 
                
                if(arr[i]!=0 && count==1)
                {
                    count2 = arr[i];
                    count++;
                }
                else
                if(arr[i]!=0 && count==2)
                {
                    Console.WriteLine("Not a blanagram");
                    return;
                }
            }
            if(count==2 && (count1+count2==0))
            {
                Console.WriteLine("It is a blanagram");
                return;
            }
            Console.WriteLine("Not a blanagram");
        }
    }
}
