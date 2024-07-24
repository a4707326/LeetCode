using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC148_Sort_List
    {
        public static void Start()
        {
            Console.WriteLine("LC148_Sort_List");

            int[] values = { -1, 5, 3, 4, 0 };
            ListNode head = ListNode.InitListNode(values);


            var ans = SortList(head);


            ListNode.PrintListNode(ans);


        }

        //Input: head = [-1,5,3,4,0]
        //Output: [-1,0,3,4,5]
        static ListNode SortList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            PriorityQueue<int,int> pq = new PriorityQueue<int,int>();
            ListNode newListNode = new ListNode();
            ListNode newHead = newListNode;
            while (head != null) 
            {
                pq.Enqueue(head.val, head.val);
                head = head.next;
            }

            while (pq.Count > 0)
            {
                newListNode.val = pq.Dequeue();
                if (pq.Count > 0)
                {
                    newListNode.next = new ListNode();
                    newListNode = newListNode.next;
                }
            }
            return newHead;
        }
    }



}
