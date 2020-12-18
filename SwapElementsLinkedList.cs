using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class SwapElementsLinkedList
    {
        public static void print(Node head)
        {
            Node cur = head;

            while (cur != null)
            {
                Console.Write("{0}->", cur.data);
                cur = cur.next;
            }
            Console.WriteLine();
        }

        public static void swap(Node head)
        {
            Node cur = head;

            while(cur!=null && cur.next!=null)
            {
                int temp = cur.data;
                cur.data = cur.next.data;
                cur.next.data = temp;
                cur = cur.next.next;
            }
        }
    }
}
