using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class DeleteNode
    {
        public static void delete(Node dNode)
        {

            dNode.data = dNode.next.data;
            dNode.next = dNode.next.next;
        }

        public static void print(Node head)
        {
            Node cur = head;
            while (cur != null)
            {
                Console.Write("{0}->",cur.data);
                cur = cur.next;
            }
            Console.WriteLine();
        }
    }
}
