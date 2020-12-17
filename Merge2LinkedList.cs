using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Merge2LinkedList
    {
        public static Node merge(Node head1,Node head2)
        {
            Node mHead = null;
            Node cur1 = null;
            Node cur2 = null;

            if (head1.data > head2.data)
            {
                mHead = head2;
                cur1 = head1;
            }
            else
            {
                mHead = head1;
                cur1 = head2;
            }


            Node prev = null;
            Node next = null;
            cur2 = mHead;
            while (cur1!=null && cur2 != null)
            {

                if (cur2.data < cur1.data)
                {
                    prev = cur2;
                    cur2 = cur2.next;
                }
                else
                {
                    next = cur1.next;
                    prev.next = cur1;
                    cur1.next = cur2;
                    cur1 = next;
                    prev = prev.next;
                }
            }

            //while(cur1!=null)
            //{
            //    cur2.next = cur1;
            //    cur1 = cur1.next;
            //}
            return mHead;
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
