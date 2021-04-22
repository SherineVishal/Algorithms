using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class TripletsSumK
    {
        //Method 1 
        /*public static void findTriplets(int[] arr,int k)
        {
           
            int sum = 0;

            for(int i=0;i<arr.Length;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    sum = arr[i] + arr[j];
                    for(int l=j+1;l<arr.Length;l++)
                    {

                        if (sum + arr[l] == k)
                        {
                            Console.WriteLine(arr[i]+" "+ arr[j] +" " + arr[l]);
                            return;
                        }
                    }
                }
            }
        }
        */

        //Method 2
        //public static void findTriplets(int[] arr,int k)
        //{
        //    if (arr.Length == 0)
        //        return;
        //    int start,end,sum=0;
        //    Array.Sort(arr);
        //    for(int i=0;i<arr.Length-2;i++)
        //    {
        //        start = i + 1;
        //        end = arr.Length - 1;
        //        while (start < end)
        //        {
        //            sum = arr[i] + arr[start] + arr[end];
        //            if (sum == k)
        //            {
        //                Console.WriteLine(arr[i] + " " + arr[start] + " " + arr[end]);
        //                return;
        //            }
        //            if (sum > k)
        //                end--;
        //            if (sum < k)
        //                start++;
        //        }
        //    }
        //}


        //Method 3

        public static void findTriplets(int[] arr,int k)
        {
            //for(int i=0;i<arr.Length;i++)
            //{
            //    HashSet<int> hs = new HashSet<int>();
            //    int currSum = k - arr[i];
            //    for(int j=i+1;j<arr.Length;j++)
            //    {
            //        if(hs.Contains(currSum-arr[j]))
            //        {
            //            Console.WriteLine(arr[i]+ " "+ arr[j]+ " " + (currSum - arr[j]));
            //        }
            //    }
            //}

            //for(int i=0;i<arr.Length;i++)
            //{
            //    for(int j=0;j<arr.Length;j++)
            //    {
            //        for(int mk=0;mk<arr.Length;mk++)
            //        {
            //            if(arr[i]+arr[j]+arr[mk]==k)
            //            {
            //                Console.WriteLine(arr[i]+ " " + arr[j] + " " + arr[mk]);
            //                return;
            //            }
            //        }
            //    }
            //}

            //Array.Sort(arr);

            //for(int i=0;i<arr.Length;i++)
            //{
            //    int start = i + 1;
            //    int end = arr.Length - 1;

            //    while(start<end)
            //    {
            //        if (arr[i] + arr[start] + arr[end] == k)
            //        {
            //            Console.WriteLine(arr[i] + " " + arr[start] + " " + arr[end]);
            //            return;
            //        }
            //        else if (arr[i] + arr[start] + arr[end] > k)

            //        {
            //            end--;
            //        }
            //        else
            //            start++;
            //    }


            //}
            //Console.WriteLine("No such element");
            int cursum = 0;
            for(int i=0;i<arr.Length;i++)
            {
                cursum = k - arr[i];
                HashSet<int> hs = new HashSet<int>();

                for(int j=i+1;j<arr.Length;j++)
                {
                    if (hs.Contains(cursum - arr[j]))
                    {
                        Console.WriteLine(arr[i] + " " + arr[j] + " " + (cursum - arr[j]));
                        return;
                    }
                    else
                        hs.Add(cursum - arr[j]);

                }
            
            }
        }

    }
}
