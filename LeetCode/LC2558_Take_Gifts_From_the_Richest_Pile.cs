using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC2558_Take_Gifts_From_the_Richest_Pile
    {
        public static void Start()
        {
            Console.WriteLine("LC2558_Take_Gifts_From_the_Richest_Pile");

            int[] gifts = { 25, 64, 9, 4, 100 };

            var ans = PickGifts(gifts,4);
            Console.WriteLine(ans);


            //foreach (int i in ans) 
            //{
            //    Console.WriteLine(i.ToString());
            //}


        }
        //[5,8,9,4,3]
        //100,64,25,9,4
        //10,64
        //Input: gifts = [25,64,9,4,100], k = 4
        //Output: 29
        //时间复杂度为O(k * n)，其中n是gifts数组的长度。
        public static long PickGifts(int[] gifts, int k)
        {
            long sum = 0;
            for (int i = 0; i < k; i++)
            {
                int maxIndex = FindIndexOfMax(gifts);
                gifts[maxIndex] = (int)Math.Sqrt(gifts[maxIndex]);
            }

            foreach (int gift in gifts)
            {
                sum += gift;
            }

            return sum;
        }
        //复杂度为O(n)
        public static int FindIndexOfMax(int[] nums)
        { 
            int max = 0;
            int maxIndex = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                { 
                    max = nums[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }


        public long PickGifts2(int[] gifts, int k)
        {
            long ans = 0;
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));
            for (int i = 0; i < gifts.Length; i++)
                pq.Enqueue(i, gifts[i]);
            while (k > 0)
            {
                if (pq.TryDequeue(out int element, out int priority))
                {
                    pq.Enqueue(element, Convert.ToInt32(Math.Floor(Math.Sqrt(priority))));
                }
                k--;
            }
            while (pq.Count > 0)
            {
                if (pq.TryDequeue(out int element, out int priority))
                    ans += priority;
            }
            return ans;
        }


    }


}
