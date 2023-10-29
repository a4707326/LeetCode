using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC2181_Merge_Nodes_in_Between_Zeros
    {
        public static void Start()
        {
            Console.WriteLine("LC2181_Merge_Nodes_in_Between_Zeros");



            // 使用示例
            int[] values = { 0, 3, 1, 0, 4, 5, 2, 0 };
            ListNode head = ListNode.InitListNode(values);


            var ans = MergeNodes3(head);


            while (ans != null)
            {
                Console.WriteLine(ans.val);
                ans = ans.next;
            }


        }


        //Input: head = [0,3,1,0,4,5,2,0]
        //Output: [4,11]
        //總的時間複雜度為 O(n + k)。
        public static ListNode MergeNodes(ListNode head)
        {
            Dictionary<int,int> dic = new Dictionary<int,int>();

            int th = 0;

            while (head != null && head.next != null) 
            {
                if (head.val == 0)
                {
                    th++;
                }

                if (dic.ContainsKey(th))
                {
                    dic[th] += head.val;
                }
                else
                {
                    dic.Add(th, head.val);

                }

                head = head.next;
            }

            ListNode ans = new ListNode();
            ListNode listNode = ans;

            for (int i = 1; i < dic.Count+1; i++)
            {
                listNode.val = dic[i];
                if (i < dic.Count)
                {
                    listNode.next = new ListNode();
                    listNode = listNode.next;
                }
            }


            return ans;
        }

        //這個程式碼的時間複雜度是 O(n)，空間複雜度是 O(1)，相對於之前的版本更加高效。
        public static ListNode MergeNodes2(ListNode head)
        {
            ListNode ans = new ListNode();
            ListNode cur = ans;

            int sum = 0;

            while (head.next != null) 
            {
                sum += head.val;

                if (head.next.val == 0)
                {
                    cur.val = sum;
                    sum = 0;
                    if (head.next.next != null )
                    {
                        cur.next = new ListNode();
                        cur = cur.next;
                    }
                }
                head = head.next;
            }

            return ans;

        }


        //Input: head = [0,3,1,0,4,5,2,0]
        //時間複雜度是 O(n)，空間複雜度是 O(1)
        //實際效能比前一版好一些
        public static ListNode MergeNodes3(ListNode head)
        {
            ListNode cur = head;

            while (cur.next != null)
            {
                ListNode nextN = cur.next;

                ListNode nextNN = nextN.next;

                if (nextN.val != 0)
                {
                    cur.val += nextN.val;
                }
                else if (nextNN != null) 
                {
                    cur = nextN;
                }

                cur.next = nextNN;
            }
            return head;
        }
    



    }


}
