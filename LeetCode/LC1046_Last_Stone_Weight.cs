using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace LeetCode
{
    internal class LC1046_Last_Stone_Weight
    {
        public static void Start()
        {
            Console.WriteLine("LC1046_Last_Stone_Weight");

            int[] stones = { 2, 7, 4, 1, 8, 1 };

            var ans = LastStoneWeight2(stones);

            Console.WriteLine(ans);

            //foreach (int i in ans) 
            //{
            //    Console.WriteLine(i.ToString());
            //}


        }

        //Input: stones = [2,7,4,1,8,1]
        //Output: 1
        //Explanation: 
        //We combine 7 and 8 to get 1 so the array converts to[2, 4, 1, 1, 1] then,
        //we combine 2 and 4 to get 2 so the array converts to[2, 1, 1, 1] then,
        //we combine 2 and 1 to get 1 so the array converts to[1, 1, 1] then,
        //we combine 1 and 1 to get 0 so the array converts to[1] then that's the value of the last stone.

        //時間複雜度是 O(n^2 log n)
        //排序的時間複雜度是 O(n log n)
        public static int LastStoneWeight(int[] stones)
        {
            List<int> list = new(stones);
            while (list.Count > 1) 
            {
                list = list.OrderByDescending(x => x).ToList<int>();

                list[1] = list[0] - list[1];
                list.RemoveAt(0);
            }
            
            return list[0];
        }



        //這個算法的時間複雜度主要取決於優先隊列（Priority Queue）的操作，包括 Enqueue、Dequeue 和 Peek。這個算法的核心操作是將兩個石頭的重量相減，然後將新的石頭放回優先隊列，直到優先隊列中只剩下一個石頭。

        //Enqueue 操作的時間複雜度： 對於優先隊列的插入操作，通常是 O(log n) 時間複雜度，其中 n 是優先隊列的大小。
        //Dequeue 操作的時間複雜度： 對於優先隊列的刪除操作，通常是 O(log n) 時間複雜度。
        //Peek 操作的時間複雜度： 取得優先隊列的頂部元素通常是 O(1) 時間複雜度。
        //所以，對於每一對石頭的操作，需要執行兩次 Dequeue 和一次 Enqueue。總的時間複雜度是 O(n log n)，其中 n 是石頭的數量。這是因為在最壞情況下，需要對 n 個石頭進行 O(log n) 次操作。

        //總的空間複雜度取決於優先隊列的空間複雜度，通常是 O(n)。這是因為需要存儲 n 個石頭的重量信息。
        public static int LastStoneWeight2(int[] stones)
        {

            var heap = new PriorityQueue<int, int>();

            foreach (var stone in stones)
                heap.Enqueue(stone, -stone);

            while (heap.Count > 1)
            {
                var newStone = heap.Dequeue() - heap.Dequeue();
                if (newStone > 0)
                    heap.Enqueue(newStone, -newStone);
            }

            return heap.Count > 0 ? heap.Peek() : 0;
        }



    }


}
