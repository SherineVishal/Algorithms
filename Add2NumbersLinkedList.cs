using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Add2NumbersLinkedList
    {
        //public static void add(Node head1,Node head2)
        //{
        //    head1 = reverse(head1);
        //    head2 = reverse(head2);

        //    Node cur1 = head1;
        //    Node cur2 = head2;
        //    int rem = 0;
        //    Node sHead=null;
        //    Node cur = null;
        //    int sum = 0;

        //    while(cur1!=null && cur2!=null)
        //    {
        //        sum = cur1.data + cur2.data + rem;
        //        if (sum > 9)
        //        {
        //            rem = sum / 10;
        //            sum = sum % 10;
        //        }
        //        else
        //            rem = 0;
        //        Node temp = new Node(sum);
        //        if (sHead == null)
        //        {
        //            sHead = temp;
        //            cur = sHead;
        //        }
        //        else
        //        {
        //            cur.next = temp;
        //            cur = temp;
        //        }
        //        cur1 = cur1.next;
        //        cur2 = cur2.next;
        //    }

        //    while(cur1!=null)
        //    {
        //        sum = cur1.data + rem;
        //        if (sum > 9)
        //        {
        //            rem = sum / 10;
        //            sum = sum % 10;
        //        }
        //        else
        //            rem = 0;
        //        Node temp = new Node(sum);

                
        //        cur.next = temp;
        //        cur = temp;
        //        cur1 = cur1.next;
        //    }

        //    while (cur2 != null)
        //    {
        //        sum = cur2.data + rem;
        //        if (sum > 9)
        //        {
        //            rem = sum / 10;
        //            sum = sum % 10;
        //        }
        //        else
        //            rem = 0;
        //        Node temp = new Node(sum);


        //        cur.next = temp;
        //        cur = temp;
        //        cur2 = cur2.next;
        //    }

        //    if (rem!=0)
        //        cur.next = new Node(rem); 

        //    sHead = reverse(sHead);
        //    print(sHead);
        //}

        public static void add(Node head1, Node head2)
        {
            head1 = reverse(head1);
            head2 = reverse(head2);

            Node cur1 = head1;
            Node cur2 = head2;
            int rem = 0;
            Node sHead = null;
            Node cur = null;
            int sum = 0;

            while (cur1 != null || cur2 != null)
            {
                sum = (cur1!=null?cur1.data:0) + (cur2!=null?cur2.data:0) + rem;
                rem = sum > 9 ? 1 : 0;
                
                sum = sum % 10;
               
                Node temp = new Node(sum);
                
                if (sHead == null)
                {
                    sHead = temp;
                    cur = sHead;
                }
                else
                {
                    cur.next = temp;
                    cur = temp;
                }
                if(cur1!=null) cur1 = cur1.next;
                if(cur2!=null) cur2 = cur2.next;
            }

           if (rem != 0)
                cur.next = new Node(rem);

            sHead = reverse(sHead);
            print(sHead);
        }

        public static Node reverse(Node head)
        {
            Node cur = head;
            Node prev = null;
            Node next = null;

            while(cur!=null)
            {
                next = cur.next;
                cur.next = prev;
                prev = cur;
                cur = next;
            }
            return (prev);
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
