using System;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC347_Top_K_Frequent_Elements
    {
        public static void Start()
        {
            Console.WriteLine("LC347_Top_K_Frequent_Elements");

            int[] nums = { 1, 1, 1, 2,4, 2, 3,3,3,3 };
            int k = 2;

            var ans = TopKFrequent(nums, k);


            foreach (int i in ans) 
            {
                Console.WriteLine(i.ToString());
            }


        }

        //Input: nums = [1,1,1,2,2,3], k = 2
        //Output: [1,2]
        //時間複雜度為 O(n + k * log(k)) 
        public static int[] TopKFrequent(int[] nums, int k)
        {

            return nums.GroupBy(x => x).OrderByDescending(x => x.Count()).Select(x => x.Key).Take(k).ToArray();
        }

        //GroupBy 操作的時間複雜度是 O(n)


        //總的時間複雜度為 O(n + n log n + k log n)

        public static int[] TopKFrequent2(int[] nums, int k)
        {
            PriorityQueue<int, int> pq = new(Comparer<int>.Create((x,y) => y-x)) ;
            Dictionary<int, int> map = new Dictionary<int, int>();
            var res = new int[k];

            for (int i = 0; i < nums.Length; i++)
            {
                if (!map.TryAdd(nums[i], 1))
                {
                    map[nums[i]]++;
                }
            }

            foreach (var item in map)
            {
                pq.Enqueue(item.Key, item.Value);
            }

            for (int i = 0; i < k; i++)
                res[i] = pq.Dequeue();

            return res;
        }

//        這兩種方法都可以解決前K個頻率最高的元素的問題，但在不同的情況下，性能可能有所不同。讓我們比較一下兩種方法的優勢和缺點：

//方法一（使用最大堆）：

//優勢：
//在最壞情況下（大部分元素的頻率都不同），時間複雜度為 O(n log n + k log n)，這比直接排序的 O(n log n) 方法更快。
//在 k 相對較小的情況下，性能優於直接排序，因為它只需要處理前K個元素。
//缺點：
//在最壞情況下（所有元素的頻率相同），空間複雜度為 O(n)，比起直接排序方法需要額外的空間。
//方法二（使用LINQ）：

//優勢：
//簡潔易讀，不需要自己實現最大堆，直接使用LINQ函數。
//在 k 相對較大的情況下，性能可能優於使用最大堆，因為它僅僅是一次排序和切片操作，時間複雜度為 O(n log n + k)。
//缺點：
//在最壞情況下，時間複雜度為 O(n log n)，即使只需要前K個元素，也需要對所有元素進行排序。
//總結來說，如果 k 相對較小，方法一（使用最大堆）可能更好，因為它的時間複雜度在最壞情況下更低。但如果 k 相對較大，方法二（使用LINQ）可能更好，因為它的實現更簡單，並且在不需要考慮最壞情況的情況下，性能可能更好。
    }


}
