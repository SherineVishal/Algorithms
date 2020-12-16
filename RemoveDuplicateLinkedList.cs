using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class RemoveDuplicateLinkedList
    {
        public static void remove(Node head)
        {
            Node cur = head;
            Node prev = null;
            Dictionary<int, int> keyValues = new Dictionary<int, int>();

            while(cur!=null)
            {
                if(!keyValues.ContainsKey(cur.data))
                {
                    keyValues[cur.data] = 1;
                    prev = cur;
                    
                }
                else
                {
                    prev.next = cur.next;

                }
                cur = cur.next;
            }
            print(head);
        }

        public static void print(Node head)
        {
            Node cur = head;

            while(cur!=null)
            {
                Console.Write("{0}->",cur.data);
                cur = cur.next;
            }
        }
    }
}
