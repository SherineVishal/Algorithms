using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class LinkedListToBST
    {
        public static TNode lToBST(Node head, Node tail)
        {
            if (head == tail)
                return null;

            Node sPtr = head;
            Node fPtr = head;

            while(fPtr!=null && fPtr.next!=null)
            {
                fPtr = fPtr.next.next;
                sPtr = sPtr.next;
            }

            TNode tHead = new TNode(sPtr.data);

            tHead.lTree = lToBST(head, sPtr);
            tHead.rTree = lToBST(sPtr.next, tail);

            return tHead;

        }

        public static void inOrderTraversal(TNode parent)
        {
            if(parent!=null)
            {
                inOrderTraversal(parent.lTree);
                Console.WriteLine(parent.data);
                inOrderTraversal(parent.rTree);
            }
        }
    }
}
