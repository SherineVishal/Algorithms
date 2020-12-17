using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class RotateCounterClockWiseLinkedList
    {
        public static Node rotate(Node head,int k)
        {
            Node cur = head;
            Node kthNode=null;
            int count = 1;
            while(cur.next!=null)
            {
                if (count == k)
                    kthNode = cur;
                cur = cur.next;
                count++;
            }

            cur.next = head;
            head = kthNode.next;
            kthNode.next = null;
            return head;
        }

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


    }
}
