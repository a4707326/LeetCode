using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC2807InsertGreatestCommonDivisorsinLinkedList
    {
        public static void Start()
        {
            Console.WriteLine("LC2807InsertGreatestCommonDivisorsinLinkedList");


            ListNode node4 = new ListNode(3);
            ListNode node3 = new ListNode(10, node4);
            ListNode node2 = new ListNode(6, node3);
            ListNode node1 = new ListNode(18, node2);


            var ans = InsertGreatestCommonDivisors2(node1);


            while (ans.next != null)
            {
                Console.WriteLine(ans.val);
                ans = ans.next;

            }
            Console.WriteLine("last");
            Console.WriteLine(ans.next);
            Console.WriteLine(ans.val);


        }

        //Input: head = [18,6,10,3]
        //Output: [18,6,6,2,10,1,3]

        /**
         * Definition for singly-linked list.
         * public class ListNode {
         *     public int val;
         *     public ListNode next;
         *     public ListNode(int val=0, ListNode next=null) {
         *         this.val = val;
         *         this.next = next;
         *     }
         * }
         */

        public static ListNode InsertGreatestCommonDivisors(ListNode head)
        {

            ListNode ansListNode = new ListNode();

            List<int> list = new List<int>();

            while (head.next != null)
            {

                list.Add(head.val);
                head = head.next;

            }
            list.Add(head.val);

            List<int> list2 = new List<int>(list);

            int x = 1;
            for (int i = 1; i < list.Count ; i++)
            {

                list2.Insert(x, GCD(list[i - 1], list[i]));
                x += 2;

            }

            for (int i = 0; i < list2.Count; i++)
            {

                if (i == list2.Count - 1)
                { 
                    ListNodeInset(ansListNode, null, list2[i]);
                }
                else
                {
                    ListNodeInset(ansListNode, new ListNode(), list2[i]);
                }
            }

            

            return ansListNode;
        }

        static void ListNodeInset(ListNode list, ListNode node, int val)
        {

            ListNode head = list;

            while (list.next != null)
            {
                list = list.next;
            }


            list.val = val;
            list.next = node;


            list = head;
        }


        //Input: head = [18,6,10,3]
        //Output: [18,6,6,2,10,1,3]
        //Input: curr = [18,6,10,3]
        //18,6
        //i0(18,i1(6,i2))
        //ni0(6,i1)
        //i0(18,ni0(6,i1))
        public static ListNode InsertGreatestCommonDivisors2(ListNode head)
        {
            var curr = head;

            while (curr != null)
            {
                if (curr.next != null)
                {
                    var gcd = GCD(curr.val, curr.next.val);
                    var newNode = new ListNode(gcd, curr.next);
                    curr.next = newNode;
                    curr = curr.next.next;
                }
                else
                {
                    curr = curr.next;
                }
            }
            return head;
        }



        //18 //6
        static int GCD(int a, int b)
        {
            if (b == 0)
                return a;

            return GCD(b, a % b);
        }

         


    }



}
