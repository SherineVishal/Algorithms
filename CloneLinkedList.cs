using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class CloneLinkedList
    {
        public static void clone(Node head)
        {
            

            Node cur = head;
            
            Node next;

            //inserting new node in between
            while(cur!=null)
            {
                next = cur.next;
                cur.next = new Node(cur.data);
                cur.next.next = next;
                cur = next;
            }

            

            //assigning random
            cur = head;
            while(cur!=null)
            {
                cur.next.rand = cur.rand.next;
                cur = cur.next.next;
            }

            //seperating original from clone
            cur = head;
            Node sHead = cur.next;
            Node sCur = head.next;
            while (cur!=null && sCur!=null)
            {
                cur.next = cur.next!=null?cur.next.next:cur.next;
                sCur.next = sCur.next != null ? sCur.next.next : sCur.next;
                cur = cur.next;
                sCur = sCur.next;
            }

            print(head);
            print(sHead);
        }

        public static void print(Node head)
        {
            Node cur = head;
            Console.WriteLine("Next");
            while(cur.next!=null)
            {
                Console.WriteLine("{0}->{1}", cur.data, cur.next.data);
                cur = cur.next;
            }

            cur = head;
            Console.WriteLine("Random");
            while (cur != null)
            {
                Console.WriteLine("{0}->{1}", cur.data, cur.rand.data);
                cur = cur.next;
            }
        }
    }
}
