using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class LinkedListPalindrome
    {
        public static void isPalindrome(Node head)
        {
            // Method 1

            //Node cur = head;
            //string str = "";
            //int i = 0;

            //while (cur != null)
            //{
            //    str = str + cur.data;
            //    cur = cur.next;
            //}
            //int l = str.Length;
            //int m = l / 2;
            //char[] strArray = str.ToCharArray();
            //for (i = 0; i < m; i++)
            //{
            //    char temp = str[i];
            //    strArray[i] = str[l - 1];
            //    strArray[l - 1] = temp;
            //    l--;
            //}
            //string revStr = new string(strArray);
            //if (str.Equals(revStr))
            //    Console.WriteLine("Is a palindrome");
            //else
            //    Console.WriteLine("Not a palindrome");

            //Method 2

            //Node cur = head;
            //Stack<char> stk = new Stack<char>();

            //while (cur != null)
            //{
            //    stk.Push(cur.data);
            //    cur = cur.next;
            //}

            //cur = head;

            //while(cur!=null)
            //{
            //    if (stk.Pop() != cur.data)
            //    {
            //        Console.WriteLine("Not a palindrome");
            //        return;
            //    }
            //    cur = cur.next;
            //}
            //Console.WriteLine("It's a palindrome");

            //Method 3

            Node fPtr = head;
            Node sPtr = head;
            Node prevSlowPtr = null;
            Node mid = null;
            Node secondhead = null;
            bool result;
            
            //find mid
            while(fPtr!=null && fPtr.next!=null)
            {
                fPtr = fPtr.next.next;
                prevSlowPtr = sPtr;
                sPtr = sPtr.next;
            }

            if(fPtr!=null)
            {
                mid = sPtr;
                sPtr = sPtr.next;

            }
            prevSlowPtr.next= null;
            secondhead = sPtr;

            secondhead=reverse(secondhead);

            result=comparerList(head, secondhead);

            if (mid != null)
            {
                mid.next = secondhead;
                prevSlowPtr.next = mid;
            }
            else
                prevSlowPtr.next = secondhead;
            Console.WriteLine(result);
        }

        public static Node reverse(Node secondhead)
        {
            Node prev = null;
            Node cur = secondhead;
            Node next = null;

            while(cur!=null)
            {
                next = cur.next;
                cur.next = prev;
                prev = cur;
                cur = next;
            }

            secondhead = prev;

            return (secondhead);
        }

        public static bool comparerList(Node firstHead,Node secondHead)
        {
            Node firstCur = firstHead;
            Node secondCur = secondHead;

            while(firstCur!=null && secondCur!=null)
            {
                if (firstCur.data == secondCur.data)
                {
                    firstCur = firstCur.next;
                    secondCur = secondCur.next;
                }
                else
                    return false;
            }
            return true;
        }
    }
}
