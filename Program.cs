using System;
using System.Collections.Generic;

namespace Algorithms
{
    class Interval
    {
        public int start;
        public int end;

        public Interval(int start, int end)
        {
            this.start = start;
            this.end = end;
        }
    }

    class Node
    {
        public int data;
        public Node next;
        public Node rand;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
            this.rand = null;
        }
    }
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


            /*
             * int[] arr = { 7, 10, 4, 3, 20, 15 };
            KthSmallest.findKthSmallest(arr, 0,5,3);
            */


            /*
             * 17.	Find missing parenthesis in a given expression – 2 * ( 3 + 5(sasdfasdfasd)
             */

            /*
            string exp = "2 * (3 + 5(sasdfasdfasd))";
            FindMissingParenthesis.findMissingParenthesis(exp);
            */

            /*
             * 18.	Evaluate an expression given only single digits and only 2 operators * and +.
             */

            /*
            string exp = "3*4+2*2";
            EvaluateExpression.evaluate(exp);
            */

            /*
             * 19.Reverse a stack and put the reversed value back in the same stack.You can use only one other stack and a temp variable.
             * */

            /*
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            ReverseStack.reverse(stack);
            */

            /*
             * 20.	Given a set of time intervals in any order, merge all overlapping intervals into one and output the result 
             * which should have only mutually exclusive intervals. Let the intervals be represented as pairs of integers for simplicity. 
             * For example, let the given set of intervals be {{1,3}, {2,4}, {5,7}, {6,8} }. 
             * The intervals {1,3} and {2,4} overlap with each other, so they should be merged and become {1, 4}. 
             * Similarly {5, 7} and {6, 8} should be merged and become {5, 8}
             * */

            /*

            List<Interval> intervals = new List<Interval>();
            intervals.Add(new Interval(1, 3));
            intervals.Add(new Interval(5,7));
            intervals.Add(new Interval(2,4));
            intervals.Add(new Interval(6, 8));

            MergeIntervals.merge(intervals);

            */

            /*
             * 
             * 21.	Given a stack of integers, write a function pairWiseConsecutive() that checks whether numbers in the stack are pairwise consecutive or not. The pairs can be increasing or decreasing, and if the stack has an odd number of elements, the element at the top is left out of a pair. The function should retain the original stack content.

            Only following standard operations are allowed on stack. 
            push(X): Enter a element X on top of stack. 
            pop(): Removes top element of the stack. 
            empty(): To check if stack is empty. 

            Examples: 
            Input : stack = [4, 5, -2, -3, 11, 10, 5, 6, 20] 
            Output : Yes 

            Each of the pairs (4, 5), (-2, -3), (11, 10) and (5, 6) consists of consecutive numbers. 

            Input : stack = [4, 6, 6, 7, 4, 3] 
            Output : No 
            (4, 6) are not consecutive.

                        */

            /*

            Stack<int> stack = new Stack<int>();
            stack.Push(4);
            stack.Push(6);
            stack.Push(6);
            stack.Push(7);
            stack.Push(4);
            stack.Push(3);


            PairWiseConsecutive.pairWiseConsecutive(stack);

            */

            /*
             * 
             * 22.	Given two expressions in the form of strings. The task is to compare them and check if they are similar. Expressions consist of lowercase alphabets, ‘+’, ‘-‘ and ‘( )’. 

            Examples: 

            Input : exp1 = "-(a+b+c)" exp2 = "-a-b-c" 

            Output : Yes 

            Input : exp1 = "-(c+b+a)" exp2 = "-c-b-a" 

            Output : Yes 

            Input : exp1 = "a-b-(c-d)" exp2 = "a-b-c-d" 

            Output : No 

            It may be assumed that there are at most 26 operands from ‘a’ to ‘z’ and every operand appears only once.

                        */

            //Not done

            /*
             * 23. Implement an algorithm to determine if a string has all unique characters. What if you cannot use additional data structures?
             */

            /*
            string str = "Sherine Tom bz";
            StringAllUniqueChar.isUnique(str);
            */

            /*
             * 24. Given two strings, write a method to decide if one is a permutation of the other?(anagram)
             */

            /*

            string str1 = "abcd abcd";
            string str2 = "bcbc adad";
            StringPermutation.isPermutation(str1, str2);
            */

            /*
             * 25. Write a method to replace all spaces in a string with ‘%20’.
             */

            /*
            string str = "Sherine Thomas";
            char[] strArray = str.ToCharArray();
            StringReplace.replace(strArray);
            */
            /*
            26.Implement a method to perform a basic string compression using the counts of repeated characters.

            For example, the string aabccccaaa would become a2b1c4a3.

            If the compressed string would not become smaller than the original string, your method should return the original string.
            */
            /*
            string str = "aabccccaaa";
            CompressionString.compress(str);
            */

            /*
              * 27.	Write an algorithm such that if an element in an MxN matrix is 0, its entire row and column are set to 0.
              */

            /*(not correct)

            int[,] arr = { { 0, 1, 1, 0 }, 
                { 1, 1, 0, 1 }, 
                { 1, 1, 1, 1 } 
            };

            SetToZeroMXN.modify(arr);

            */

            /*
             * 29.	Find negative numbers in an array
             */

            /*

            int[] arr = { 1, -3, -4, 9 };
            FindNegative.findNegative(arr);

            */

            /* 30. Find duplicates in a given array
             */

            /*int[] arr = { 2, 1, 4, 3, 1, 2, 5 };
            FindDuplicates.find(arr);*/

            /*
             * 31. Write an algorithm to determine if a linkedlist is a palindrome
             * */

            /*
            Node head = new Node('a');
            head.next = new Node('b');
            head.next.next = new Node('c');
            head.next.next.next = new Node('c');
            head.next.next.next.next = new Node('b');
            

            LinkedListPalindrome.isPalindrome(head);
            */

            /* 32. Write an algorithm to determine if a linkedlist is circular. FOLLOW UP: Determine where the circle meets.
             * */

            /*
            Node head = new Node('a');
            Node bNode = new Node('b');
            Node cNode = new Node('c');
            Node dNode = new Node('d');
            Node eNode = new Node('e');
            Node fNode = new Node('f');
            head.next = bNode;
            bNode.next = cNode;
            cNode.next = dNode;
            dNode.next = eNode;
            eNode.next = fNode;
            fNode.next = cNode;

            Console.WriteLine(CircularLinkedList.isCircular(head));
            */

            /* 33. Clone a linked list with a random pointer.*/



            //Node head = new Node('a');
            //Node bNode = new Node('b');
            //Node cNode = new Node('c');
            //Node dNode = new Node('d');
            //Node eNode = new Node('e');
            //Node fNode = new Node('f');

            //head.next = bNode;
            //bNode.next = cNode;
            //cNode.next = dNode;
            //dNode.next = eNode;
            //eNode.next = fNode;


            //head.rand = dNode;
            //bNode.rand = head;
            //cNode.rand = fNode;
            //dNode.rand = eNode;
            //eNode.rand = bNode;
            //fNode.rand = cNode;


            //CloneLinkedList.clone(head);

            /*
             * 34.	Write code to remove duplicates from an unsorted linked list. Follow up: How would you solve it if temporary buffer is not allowed?
             * */



            //Node head = new Node(3);
            //Node bNode = new Node(1);
            //Node cNode = new Node(3);
            //Node dNode = new Node(5);
            //Node eNode = new Node(2);
            //Node fNode = new Node(1);

            //head.next = bNode;
            //bNode.next = cNode;
            //cNode.next = dNode;
            //dNode.next = eNode;
            //eNode.next = fNode;

            //RemoveDuplicateLinkedList.remove(head);

            /*
             * 35.Implement an algorithm to find the kth to the last element of a singly linked list
             * */

            //Node head = new Node(1);
            //Node bNode = new Node(2);
            //Node cNode = new Node(3);
            //Node dNode = new Node(4);
            //Node eNode = new Node(5);
            //Node fNode = new Node(6);

            //head.next = bNode;
            //bNode.next = cNode;
            //cNode.next = dNode;
            //dNode.next = eNode;
            //eNode.next = fNode;

            //KthFromLastLinkedList.find(head,4);

            /*
             * 36. Implement an algorithm to delete a node a singly linked list, given only access to that node.
             */

            //Node head = new Node(1);
            //Node bNode = new Node(2);
            //Node cNode = new Node(3);
            //Node dNode = new Node(4);
            //Node eNode = new Node(5);
            //Node fNode = new Node(6);

            //head.next = bNode;
            //bNode.next = cNode;
            //cNode.next = dNode;
            //dNode.next = eNode;
            //eNode.next = fNode;

            //DeleteNode.print(head);
            //DeleteNode.delete(cNode);
            //DeleteNode.print(head);

            /* 
             * 37. Write code to partition a linkedlist around a value x, such that all nodes less than x come before all nodes great than or equal to x
             */

            //Node head = new Node(4);
            //Node bNode = new Node(2);
            //Node cNode = new Node(6);
            //Node dNode = new Node(3);
            //Node eNode = new Node(1);
            //Node fNode = new Node(5);

            //head.next = bNode;
            //bNode.next = cNode;
            //cNode.next = dNode;
            //dNode.next = eNode;
            //eNode.next = fNode;

            //SortLinkedList.print(head);
            //Node node=SortLinkedList.sort(head,3);
            //SortLinkedList.print(node);

            /*
             * 38. Reverse a linkedlist iteratively and recursively
             * */

            //Node head = new Node(1);
            //head.next = new Node(2);
            //head.next.next = new Node(3);
            //head.next.next.next = new Node(4);
            //head.next.next.next.next = new Node(5);

            //LinkedListReverse.print(head);

            //Node node=LinkedListReverse.reverse(head);
            //Node node = LinkedListReverse.recursiveReverse(head);

            //LinkedListReverse.print(node);

            /*
             * Given a singly linked list which has data sorted in ascending order, construct a balanced BST.
             */



            /*
             * Ex1: Blanagram
             */
            /*
            string str1 = "abcd abcd";
            string str2 = "bcbc eded";

            Blanagram.isPermutation(str1, str2);*/

            /* Ex2: QuickSort */

            /*QuickSort.quickSort(arr, 0, 4);

            foreach (var item in arr)
                Console.WriteLine(item);*/

            /*
             * Ex3: Find a count of a word in a string
             */
            //search for single word

            /*
            string str = "And and is a by and";
            string word = "and";

            FindWordOccurrence.findOccurence(str,word);*/

            //count the occurence of multiple words
            /*
            string str = "And and is a by and is a";
            string[] words = { "and" ,"is","by"};

            FindWordOccurrence.findOccurences(str, words);
            */

            /*
             * Ex4: Reverse a string
             */
            /*
            string str = "Madam, I'm Adam";
            ReverseString.reverse(str);
            */

            /* Ex 5: nth fibonacci number */

            /*int n = 10;
            Console.WriteLine(Fibonacci.fiboWithoutRec(n));*/

            /* Ex 6: print the fibonacci series */
            /*
            int n = 10;
            for (int i = 0; i < 10; i++)
                Console.WriteLine(Fibonacci.fibonacci(i));*/

            /* Ex 7: Multiplication table */
            /*
            int n = 12, m = 12;

            MultiplicationTable.print(n, m);
            */

            /* Ex 8: Sum from file */

            /*SumFromFile.findSum();*/

            /*
             * Ex 9: Odd numbers 
             */
            /*

            OddNumbers.print();
                */
            /*
            int n=100;
            PrimeNumbers.print(n);
            */

            /* Ex 10: Find the largest int value in an int array */
            /*
            int[] arr = { 12,23,15,87,56,32,76};
            Console.WriteLine(LargestValue.findMax(arr));
            */

            /*
             * Format an RGB value (three 1-byte numbers) as a 6-digit hexadecimal string.
             */

            /*
            int r = 1000, g=0,b=0;
            RGBToHex.convert(r,g,b);

            string hex= "3E8";
            RGBToHex.convertHexToInt(hex);
            */


            /*
             * Middle of a linked list */
            /*

            Node head = new Node(1);
            head.next = new Node(2);
            head.next.next = new Node(3);
            head.next.next.next = new Node(4);
            head.next.next.next.next = new Node(5);

            LinkedListMiddle.middle(head);

                */

        }

    }
}
