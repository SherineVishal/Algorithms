using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class LinkedListReverse
    {
        public static Node reverse(Node head)
        {
            if (head == null || head.next==null)
                return head;
                        
            Node prev = null;
            Node cur = head;
            Node next=null;
            while (cur!=null)
            {
                next = cur.next;
                cur.next = prev;
                prev = cur;
                cur = next;
            }
            head = prev;
            return head;
        }

        public static Node recursiveReverse(Node head)
        {
            if (head == null || head.next == null)
                return head;

            Node newHead = recursiveReverse(head.next);

            head.next.next = head;
            head.next = null;

            return newHead;
        }

        public static void print(Node head)
        {
            Node cur = head;

            while(cur!=null)
            {
                Console.Write("{0}->",cur.data);
                cur = cur.next;
            }
            Console.WriteLine();
        }


    }
}
