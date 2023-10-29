using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC2130_Maximum_Twin_Sum_of_a_Linked_List
    {
        public static void Start()
        {
            Console.WriteLine("LC2130_Maximum_Twin_Sum_of_a_Linked_List");




            // 初始化 head
            int[] values = { 5, 4, 2, 1 };
            ListNode head = ListNode.InitListNode(values);
            var ans = PairSum(head);

            Console.WriteLine(ans);


            //foreach (int i in ans) 
            //{
            //    Console.WriteLine(i.ToString());
            //}


        }

        //Input: head = [5,4,2,1]
        //Output: 6
        //時間複雜度為O(n)
        public static int PairSum(ListNode head)
        {
            ListNode cur = head;
            List<int> list = new List<int>();
            int max = 0;

            while (cur != null) 
            {
                list.Add(cur.val);
                cur = cur.next;
            }

            for (int i = 0,j = list.Count-1; i < list.Count / 2 ; i++,j--)
            {
                max = Math.Max(max, list[i] + list[j]);
            }

            return max;
        }
        //0 1 2 3 4 5 //5
        //0 1 2 3 4 5 6 7//7






    }


}
