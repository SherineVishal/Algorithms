using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class FindPairWithNDiff
    {
        public static void findPair(int[] arr,int n)
        {
            if (arr.Length == 0)
                return;
            /*for(int i=0;i<arr.Length;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(Math.Abs(arr[i]-arr[j])==n)
                    {
                        Console.WriteLine(arr[i] + " " + arr[j]);
                        break;
                    }
                }
            }
            */
            //Array.Sort(arr);

            //int i = 0, j = 0;
            //while(i<arr.Length && j<arr.Length)
            //{
            //    if(arr[j]-arr[i]==n)
            //    {
            //        Console.WriteLine($"{arr[i]},{arr[j]}");
            //        return;
            //    }
            //    if ((arr[j] - arr[i]) < n)
            //    {
            //        j++;
            //    }
            //    else
            //    {
            //        i++;
            //    }
            //}
            //Console.WriteLine("No such pair");


            //for(int i=0;i<arr.Length;i++)
            //{
            //    for(int j=i+1;j<arr.Length;j++)
            //    {
            //        if(Math.Abs(arr[i]-arr[j])==n)
            //        {
            //            Console.WriteLine(arr[i] + " " + arr[j]);
            //            return;
            //        }
            //    }
            //}

            //Console.WriteLine("No such pair");

            Array.Sort(arr);

            int i = 0;
            int j = 1;

            while(i<arr.Length && j<arr.Length)
            {
                if (i != j && arr[j] - arr[i] == n)
                {
                    Console.WriteLine(arr[i] + " " + arr[j]);
                    return;
                }
                else if (arr[j] - arr[i] < n)
                    j++;
                else
                    i++;

            }

            Console.WriteLine("No such element found");
        }
    }
}
