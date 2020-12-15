using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class LinkedListReverse
    {
        public static void reverse(Node head)
        {
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

            cur = head;
            while (cur != null)
            {
                Console.WriteLine(cur.data);
                cur = cur.next;
            }
        }       
    }
}
