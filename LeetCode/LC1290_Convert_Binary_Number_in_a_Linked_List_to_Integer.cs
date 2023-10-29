using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1290_Convert_Binary_Number_in_a_Linked_List_to_Integer
    {

        //static int ans = 0;

        public static void Start()
        {
            Console.WriteLine("LC1290_Convert_Binary_Number_in_a_Linked_List_to_Integer");

            ListNode head = new ListNode(1);
            head.next = new ListNode(0);
            head.next.next = new ListNode(1);
            //int[] nums = { -4, -1, 0, 3, 10 };

            var ans = GetDecimalValue2(head);



            //ans += (int)Math.Pow(2, 0); ;
            //Console.WriteLine(1<<1);


            //foreach (int i in ans) 
            //{
            //    Console.WriteLine(i.ToString());
            //}
            Console.WriteLine(ans.ToString());


        }

        //000 0
        //001 1
        //010 2
        //011 3
        //100 4
        //101 5
        //110 6
        //111 7
        //1000 8


        //Input: head = [1,0,1]
        //Output: 5
        public static int GetDecimalValue(ListNode head)
        {

            List<int> list = new List<int>();
            int ans = 0;

            list.Add(head.val);
            while (head.next != null) 
            {
                list.Add(head.next.val);
                head = head.next;
            }

            for (int i = list.Count-1, j = 0; i >= 0  ; i--,j++)
            {
                if (list[i] == 1)
                {
                    ans += (int)Math.Pow(2, j); ;
                }
            }

            return ans;
        }


        public static int GetDecimalValue2(ListNode head)
        {
            int ans = 0;

            while (head != null)
            {
                ans = (ans << 1) + head.val;
                head = head.next;
            }

            return ans;
        }



    }


}
