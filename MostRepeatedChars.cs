using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class MostRepeatedChars
    {
        public static void mostRepeated(string str)
        {

            //int[] arr = new int[256];
            //int index=-1;


            //foreach(var item in str)
            //{
            //    if (item.Equals(' '))
            //        continue;
            //    arr[item]++;
            //}

            //int max = int.MinValue;

            //for(int i=0;i<256;i++)
            //{
            //    if(arr[i]>max)
            //    {
            //        max = arr[i];
            //        index = i;
            //    }
            //}

            //char maxChar = (char)index;
            //Console.WriteLine(maxChar);

            /*
                        //Method 2
                        str = str.ToLower();
                        if (str.Length == 0)
                            return;
                        Dictionary<char, int> keyValues = new Dictionary<char, int>();
                        foreach (var item in str)
                        {
                            if (item.Equals(' '))
                                continue;
                            if (keyValues.ContainsKey(item))
                            {
                                keyValues[item]++;
                            }
                            else
                            {
                                keyValues[item] = 1;
                            }
                        }

                        int max = int.MinValue;
                        char maxChar = ' ';

                        foreach (var item in keyValues)
                        {
                            if (item.Value > max)
                            {
                                maxChar = item.Key;
                                max = item.Value;
                            }
                        }

                        Console.WriteLine(maxChar);
             
             
             
             */

            ///practice

            //Dictionary<char, int> keyValue = new Dictionary<char, int>();
            //foreach(var item in str)
            //{
            //    if(keyValue.ContainsKey(item))
            //    {
            //        keyValue[item]++;
            //    }
            //    else
            //    {
            //        keyValue[item] = 1;
            //    }
            //}

            //int max = int.MinValue;
            //int maxChar = ' ';
            //foreach(var item in keyValue)
            //{
            //    if(item.Value>max)
            //    {
            //        max = item.Value;
            //        maxChar = item.Key;
            //    }
            //}

            //Console.WriteLine(maxChar);

            int[] arr = new int[256];

            foreach(var item in str)
            {
                arr[item]++;
            }

            int max = int.MinValue;
            int index = -1;
            for(int i= 0;i<arr.Length;i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    index = i;
                }
            }

            Console.WriteLine((char)index);
        }

        
            
    }
}
