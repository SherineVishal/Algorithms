using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class CircularLinkedList
    {
        public static bool isCircular(Node head)
        {
            Node sPtr = head;
            Node fPtr = head;
            bool res = false;

            while(fPtr!=null && fPtr.next!=null)
            {
                fPtr = fPtr.next.next;
                sPtr = sPtr.next;
                if (fPtr == sPtr)
                {
                    res = true;
                    break;
                }
            }

            if (res == true)
            {
                fPtr = head;
                while (fPtr != sPtr)
                {
                    fPtr = fPtr.next;
                    sPtr = sPtr.next;
                }

                Console.WriteLine("Meets at {0}",fPtr.data);
            }
            
            return res;
        }
    }
}
