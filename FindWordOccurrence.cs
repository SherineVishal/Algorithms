using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class FindWordOccurrence
    {
        //search for single word
        public static void findOccurence(string str,string word)
        {
            string[] words = str.Split(" ");
            int count = 0;

            foreach(var item in words)
            {
                if (item.ToLower().Equals(word.ToLower()))
                    count++;
            }

            Console.WriteLine("'{0}' occurs {1} times",word,count);            
        }

        //search for mutiple word occurence

        public static void findOccurences(string str,string[] words)
        {
            //Method 1

            /*string[] strArray = str.Split(" ");
            
            foreach(var word in words)
            {
                int count = 0;
                foreach(var item in strArray)
                {
                    if (item.ToLower().Equals(word.ToLower()))
                        count++;
                }
                Console.WriteLine("'{0}' occurs {1}", word, count);
            }*/

            //Method 2

            Dictionary<string, int> keyValues = new Dictionary<string, int>();

            string[] strArray = str.Split(" ");
            foreach(var item in strArray)
            {
                if (!keyValues.ContainsKey(item.ToLower()))
                    keyValues[item.ToLower()] = 1;
                else
                    keyValues[item.ToLower()]++;
            }

            foreach(var item in words)
            {
                Console.WriteLine("'{0}' occured {1} times",item, keyValues[item]);
            }
        }
    }
}
