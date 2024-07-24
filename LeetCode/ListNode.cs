using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public static ListNode InitListNode(int[] nums)
        {
            //int[] nums = { 3, 1, 2, 4 };

            ListNode dummy = new();
            ListNode current = dummy;
            foreach (int num in nums)
            {
                current.next = new ListNode(num);
                current = current.next;
            }

            ListNode head = dummy.next; // 鏈表的開頭節點
                                        // 現在你可以使用 head 作為鏈表的開頭

            return head;
        }

        public static void PrintListNode(ListNode node)
        {
            ListNode prtNode = node;


             while(prtNode != null)
             {
                Console.WriteLine(prtNode.val);
                prtNode = prtNode.next;
             }
            //if (prtNode == null)
            //{
            //    Console.WriteLine(0);
            //}
        }

    }
}
