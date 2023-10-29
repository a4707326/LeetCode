using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC206_Reverse_Linked_List
    {
        //static ListNode ansNode;
        public static void Start()
        {
            Console.WriteLine("LC206_Reverse_Linked_List");

            //int[] nums = { -4, -1, 0, 3, 10 };

            ListNode head = new ListNode(1);
            head.next = new ListNode(2);


            var ans = ReverseList(head);

            Console.WriteLine(ans.val);
            Console.WriteLine(ans.next.val);


            //foreach (int i in ans) 
            //{
            //    Console.WriteLine(i.ToString());
            //}


        }

        //Input: head = [1,2]
        //Output: [2,1]
        public static ListNode ReverseList(ListNode head)
        {

            if (head == null) return null;
            List<ListNode> list = new List<ListNode>();
            ListNode RevNode = new ListNode();
            ListNode ansNode = RevNode;


            while (head != null)
            {
                list.Add(head);
                head = head.next;
            }

            for (int i = list.Count - 1; i >= 0; i--)
            {
                RevNode.val = list[i].val;
                if (i != 0)
                {
                    RevNode.next = new ListNode();
                    RevNode = RevNode.next;
                }

            }

            return ansNode;
        }


        public static ListNode ReverseList2(ListNode head)
        {
            ListNode prev = null;  // 用於存儲前一個節點
            ListNode current = head;

            while (current != null)
            {
                ListNode nextTemp = current.next;  // 暫存下一個節點
                current.next = prev;  // 將當前節點的 next 指向前一個節點，實現反轉

                // 更新 prev 和 current 指針
                prev = current;
                current = nextTemp;
            }

            return prev;  // 反轉後的新鏈表的頭節點
        }


        public static ListNode ReverseList3(ListNode head)
        {
            ListNode resultNode = null;
            while (head != null)
            {
                resultNode = new ListNode(head.val, resultNode);
                head = head.next;
            }
            return resultNode;
        }

        //public static void ReverseListStart(ListNode head)
        //{
        //    if (head != null)
        //    {
        //        ansNode = new ListNode();
        //        ansNode.val = head.val;
        //        ansNode.next = head.;

        //        ReverseListStart()


        //    }

        //    return null;
        //}




    }


}
