using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class SortLinkedList
    {
        public static Node sort(Node head,int k)
        {
            if (head == null)
                return null;
            Node lesserHead = new Node(-1);
            Node lesserTail = lesserHead;
            Node greaterHead = new Node(-1);
            Node greaterTail = greaterHead;

            Node cur = head;

            while(cur!=null)
            {
                if(cur.data<k)
                {
                    lesserTail.next = cur;
                    lesserTail = cur;
                }
                else
                {
                    greaterTail.next = cur;
                    greaterTail = cur;
                }
                cur = cur.next;
            }

            greaterTail.next = null;
            lesserTail.next = greaterHead.next;

            return (lesserHead.next);
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
