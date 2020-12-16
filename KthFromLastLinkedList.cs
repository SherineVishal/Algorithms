using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class KthFromLastLinkedList
    {
        public static void find(Node head,int k)
        {
            Node fptr = head;
            Node sPtr = head;
            int count = 0;

            while(fptr!= null)
            {
                fptr = fptr.next;
                if (count >= k)
                    sPtr = sPtr.next;
                count++;
            }

            Console.WriteLine(sPtr.data);
        }
    }
}
