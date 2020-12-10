using System;

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

            6. Given an array of numbers, 
                split the array into two where one array contains the sum of n - 1 numbers and the other array with all the n - 1 elements.

            */

            /*

            int[] arr = { 1, 5, 8, 6, 20 };
            SplitTheArray.split(arr);

            */



            /*

            7. Write an efficient program to 
            find the sum of contiguous subarray within a one-dimensional array of numbers which has the largest sum. 
            */

            /*
            int[] arr = { -2,-3,4,-1,-2,1,5,-3};
            LargestSumContiguousSubarray.largestSum(arr);
            */

            /*
             * 8. You are given a list of n-1 integers and these integers are in the range of 1 to n. There are no duplicates in list. 
             * One of the integers is missing in the list. Write an efficient code to find the missing integer.
             * */

            /*
            int[] arr = { 1,4,2,5};
            FindMissingNumberInFirstN.findMissing(arr);
            */

            /*
             * 9. Given an unsorted array of nonnegative integers, find a continous subarray which adds to a given number.
             */

            /*
             int[] arr = { 1, 4 };
            FindSubarrayWithGivenSum.findSubArray(arr,0);
            */

            /*
             * 10. Given an unsorted array of integers(both negative and positive), find a subarray which adds to a given number. 
             * If there are more than one subarrays with sum as the given number, print any of them.
             * */

            /*

            int[] arr = { 10, 2, -2, -20, 10 };
            FindSubarrayWithGivenSumNegative.findSubArray(arr, -10);

            */

            /*
             * 11. Write a program to sort an array of 0's,1's and 2's in ascending order.
             */

            /*

            int[] arr = { 0,2,2,1,1,0,0,1,2};
            SortZeroOneTwo.Sort012(arr);

            */

            /*
             * 12. Equilibrium index of an array is an index such that the sum of elements at lower indexes is equal to the sum of elements at higher indexes. For example, in an array A:
            Example :

            Input : A[] = {-7, 1, 5, 2, -4, 3, 0}

            Output : 3

            3 is an equilibrium index, because:

            A[0] + A[1] + A[2]  =  A[4] + A[5] + A[6]

                        */
            /*
            int[] arr = { -7, 1, 5, 2, -4, 3, 0 };
            EquilibriumIndex.findEquilibriumIndex(arr);

            */

            /*
             * 13. Write a program to print all the LEADERS in the array.
             * An element is leader if it is greater than all the elements to its right side. 
             * And the rightmost element is always a leader. For example int the array {16, 17, 4, 3, 5, 2}, leaders are 17, 5 and 2.
             * */

            /*
             int[] arr = { 16, 17, 4, 3, 5, 2 };
            Leaders.printLeaders(arr);
            */

            /* 
             * 14. Given a 2D array, print it in spiral form. See the following examples.
            Examples:

            Input:

            1    2   3   4

            5    6   7   8

            9   10  11  12

            13  14  15  16

            Output:

            1 2 3 4 8 12 16 15 14 13 9 5 6 7 11 10





            Input:

            1   2   3   4  5   6

            7   8   9  10  11  12

            13  14  15 16  17  18

            Output:

            1 2 3 4 5 6 12 18 17 16 15 14 13 7 8 9 10 11

                        */

            /*

            int[,] arr =
            {
                { 1,   2,   3,   4, 5, 6},

                { 7,   8, 9, 10, 11, 12 },

                { 13, 14, 15, 16, 17, 18},

            };

            PrintSpiral.print(arr);

            */

            /*
             * 15. Print the elements of an array in the decreasing frequency if 2 numbers have same frequency then print the one which came first.
             * */

            /*
             * 
            int[] arr = { 3, 1, 5, 3, 5, 3 };
            SortBasedOnFrequency.sort(arr);

            */

            /* 
             * 16. Given an array and a number k where k is smaller than size of array, 
             * we need to find the k’th smallest element in the given array. It is given that ll array elements are distinct.
             * */


            int[] arr = { 7, 10, 4, 3, 20, 15 };
            KthSmallest.findKthSmallest(arr, 0,5,3);
            


            /*QuickSort.quickSort(arr, 0, 4);

            foreach (var item in arr)
                Console.WriteLine(item);*/





}
}
}
