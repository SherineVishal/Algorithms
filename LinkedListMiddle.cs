using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class LinkedListMiddle
    {
        public static void middle(Node head)
        {
            Node fastPtr = head;
            Node slowPtr = head;

            while(fastPtr.next!=null)
            {
                fastPtr = fastPtr.next.next;
                slowPtr = slowPtr.next;
            }

            Console.WriteLine(slowPtr.data);
        }
    }
}
