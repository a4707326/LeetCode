using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC876Middle_of_the_Linked_List
    {
        public static void Start()
        {
            Console.WriteLine("LC876Middle_of_the_Linked_List");



            int[] nums = { 3, 1, 2, 4 };
            ListNode head = ListNode.InitListNode(nums);


            var ans = MiddleNode(head);







            Console.WriteLine(ans.val.ToString());

        }


        //Input: nums = [3,1,2,4]
        //Output: [2,4,3,1]
        public static ListNode MiddleNode(ListNode head)
        {
            ListNode ans = head;

            int len = 1;
            while (head.next != null) 
            {
                len++;
                head = head.next;
            }

            for (int i = 0; i < len / 2; i++)
            {
                ans = ans.next;
            }

            return ans;
        }







    }


}
