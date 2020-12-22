using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class ReverseLinkedListK
    {
        public static Node reverse(Node head, int k)
        {
            Node prev = null;
            Node cur = head;
            Node next = null;
            int count = 0;
            while (cur != null && count < k)
            {
                next = cur.next;
                cur.next = prev;
                prev = cur;
                cur = next;
                count++;
            }

            if (cur != null)
                head.next = reverse(next, k);
            return prev;
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
