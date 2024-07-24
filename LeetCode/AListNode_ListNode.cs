using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class AListNode_ListNode
    {
        public static void Start()
        {
            Console.WriteLine("AListNode_ListNode");

            int[] nums = { 3, 1, 2, 4 };
            ListNode head = ListNode.InitListNode(nums);

            var ans = AListNode_ListNodeF(head);

            //foreach ( var i in ans ) 
            //{
            //    Console.WriteLine(i.ToString());
            //}

            //Console.WriteLine(ans.val.ToString());
            ListNode.PrintListNode(ans);

        }

        //Input: nums = [3,1,2,4]
        //Output: [2,4,3,1]
        public static ListNode AListNode_ListNodeF(ListNode head)
        {
            ListNode ans = head;


            return ans;
        }







    }


}
