using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC445_Add_Two_Numbers_II
    {
        public static void Start()
        {
            Console.WriteLine("AListNode_ListNode");

            int[] nums = { 7, 2, 4, 3 };
            int[] nums2 = { 5, 6, 4 };
            //int[] nums = { 5 };
            //int[] nums2 = { 5 };
            ListNode head = ListNode.InitListNode(nums);
            ListNode head2 = ListNode.InitListNode(nums2);

            var ans = AddTwoNumbers2(head, head2);

            //foreach ( var i in ans ) 
            //{
            //    Console.WriteLine(i.ToString());
            //}

            ListNode.PrintListNode(ans);
            //Console.WriteLine(ans.val.ToString());

        }

        //Input: l1 = [7,2,4,3], l2 = [5,6,4]
        //Output: [7,8,0,7]
        //失敗無法多次進位
        static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode headL1 = l1;
            ListNode headL2 = l2;
            ListNode headL3  = new();


            int l1Len = 0;
            int l2Len = 0;

            while (l1 != null) 
            {
                l1Len++;
                l1 = l1.next;
            }
            while (l2 != null)
            {
                l2Len++;
                l2 = l2.next;
            }

            ListNode headLBack = null;
            ListNode headAns = headL3;

            while (Math.Max(l1Len, l2Len) > 0)
            {
                
                if (l1Len > l2Len)
                {
                    headL3.val = headL1.val;
                    headL1 = headL1.next;
                    l1Len--;
                }
                else if(l1Len < l2Len)
                {
                    headL3.val = headL2.val;
                    headL2 = headL2.next;
                    l2Len--;
                }
                else
                {
                    headL3.val = headL1.val + headL2.val;
                    headL1 = headL1.next;
                    headL2 = headL2.next;
                    l1Len--;
                    l2Len--;
                }

                while (headL3.val >= 10 )
                {
                    if (headLBack == null)
                    {
                        headLBack = new();
                        headLBack.val = 0;
                        headLBack.next = headL3;
                        headAns = headLBack;
                    }

                    headLBack.val++;
                    headL3.val -= 10;


                }
                headLBack = headL3;
                if (Math.Max(l1Len, l2Len) > 0)
                {
                    headL3.next = new();
                    headL3 = headL3.next;
                }
            }
            return headAns;
        }

        static ListNode AddTwoNumbers2(ListNode l1, ListNode l2)
        {
            ListNode curr, prev = null;

            Stack<int> st1 = new Stack<int>();
            Stack<int> st2 = new Stack<int>();

            while (l1 != null)
            { 
                st1.Push(l1.val);
                l1 = l1.next; 
            }
            while (l2 != null)
            { 
                st2.Push(l2.val);
                l2 = l2.next;
            }

            int a = 0, b = 0, above = 0;
            while (st1.Count > 0 || st2.Count > 0 || above > 0)
            {
                if (st1.Count > 0) a = st1.Pop(); else a = 0;
                if (st2.Count > 0) b = st2.Pop(); else b = 0;
                // Create a node
                curr = new ListNode();
                curr.val = (a + b + above) % 10;
                curr.next = prev;
                prev = curr;
                // count above
                above = (a + b + above) / 10;
            }
            return prev;
        }


    }


}
