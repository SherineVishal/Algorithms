﻿using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
              
            1.Find the element that appears once in a sorted array where all other elements appear twice one after another. 
            Find that element in 0(logn) complexity. 
             
            Input: arr[] = {1, 1, 3, 3, 4, 5, 5, 7, 7, 8, 8} 
            Output: 4
            
            */

            /*

            int[] arr = { 1,1, 3, 3, 4,5, 5, 7, 7, 8,8}; 
            FindSingleInSortedArray.findSingle(arr,0,arr.Length-1);

            /*

            2.	A magic index in an array A[0…n-1] is defined to be an index such that A[i] = i. 
            Given a sorted array of distinct integers, write a method to find a magic index if one exists, in an array A.

             */

            /*

            int[] arr = { -2,0,3,4,8,14};
            MagicIndexInSortedArray.findMagicIndex(arr, 0, arr.Length - 1);

            */

            /*

            3. Given a sorted array of n integers that has been rotated an unknown number of times, write code to find an element in the array. 
            You may assume that the array was originally sorted in increasing order.

            */

            /*

            int[] arr = { 4, 5, 6, 1, 2, 3 };
            FindElementFromSortedRotatedArray.splitAndFind(arr, 7);

            */

            /*

            4. Given an array that contains numbers from 1 to n-1 and exactly 1 duplicate, find that duplicate.

            */

            /*

            int[] arr = { 1, 2, 3, 4, 4, 5, 6 };
            FindDuplicateNumberInFirstN.findDuplicate(arr);

            */


            /*

            5.	Search an element in an array where difference between adjacent elements is 1.

             */

            /*

            int[] arr = { 8, 7, 6, 7, 6, 5, 4, 3, 2, 3, 4, 3 };
            FindElementAdjacentDifferenceOne.findElement(arr, 3);

            */

            /*
             
            Given an array of numbers, 
                split the array into two where one array contains the sum of n - 1 numbers and the other array with all the n - 1 elements.

            */

            int[] arr = { 1, 5, 8, 6, 20 };
            SplitTheArray.split(arr);
}
}
}
