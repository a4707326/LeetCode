using System;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC2336_Smallest_Number_in_Infinite_Set
    {
        public static void Start()
        {
            Console.WriteLine("LC2336_Smallest_Number_in_Infinite_Set");


            SmallestInfiniteSet2 smallestInfiniteSet = new SmallestInfiniteSet2();

            smallestInfiniteSet.AddBack(2);    // 2 is already in the set, so no change is made.
            smallestInfiniteSet.PopSmallest(); // return 1, since 1 is the smallest number, and remove it from the set.
            smallestInfiniteSet.PopSmallest(); // return 2, and remove it from the set.
            smallestInfiniteSet.PopSmallest(); // return 3, and remove it from the set.
            smallestInfiniteSet.AddBack(1);    // 1 is added back to the set.
            smallestInfiniteSet.PopSmallest(); // return 1, since 1 was added back to the set and
                                               // is the smallest number, and remove it from the set.
            smallestInfiniteSet.PopSmallest(); // return 4, and remove it from the set.
            smallestInfiniteSet.PopSmallest(); // return 5, and remove it from the set.


        }




    }

    //Input
    //["SmallestInfiniteSet", "addBack", "popSmallest", "popSmallest", "popSmallest", "addBack", "popSmallest", "popSmallest", "popSmallest"]
    //[[], [2], [], [], [], [1], [], [], []]
    //Output
    //[null, null, 1, 2, 3, null, 1, 4, 5]
    public class SmallestInfiniteSet
    {
        List<int> list;

        public SmallestInfiniteSet()//時間複雜度為 O(1)
        {
            list = new List<int>();
            for (int i = 1; i <= 1000; i++)
            {
                list.Add(i);
            }
        }

        public int PopSmallest()//操作的時間複雜度為 O(n)
        {
            int min = list[0];
            list.RemoveAt(0);
            return min;
        }

        public void AddBack(int num)//方法的時間複雜度都是 O(n)
        {

            for (int i = 0; i < list.Count; i++)
            {

                if (list[i] == num) 
                {
                    return;   
                }
                if (list[i] > num)
                {
                    list.Insert(i, num);
                    return;
                }
            }
            
        }
    }


//    在兩個 SmallestInfiniteSet 的實現中，SmallestInfiniteSet2 使用了 PriorityQueue 這種資料結構，它通常能夠在維護有序性方面提供更好的性能，尤其在需要頻繁的插入和刪除操作時。這是因為 PriorityQueue 的設計使得這些操作的時間複雜度是 O(log n)，而不是 O(n)。
//相反，SmallestInfiniteSet 使用了 List 這種簡單的動態數組結構，它的插入和刪除操作的時間複雜度是 O(n)，因為在插入時，需要將元素後面的所有元素向後移動一位。
//所以，如果需要高效率的插入和刪除操作，特別是在大數據量的情況下，使用 SmallestInfiniteSet2 的實現更為適合。而如果對性能的需求不高，或者處理的數據量較小，SmallestInfiniteSet 的實現也是可以接受的。
    public class SmallestInfiniteSet2
    {
        PriorityQueue<int, int> pq;
        public SmallestInfiniteSet2()
        {
            //var a = Enumerable.Range(1, 1000);
            pq = new PriorityQueue<int, int>(Enumerable.Range(1, 1000).Select(x => (x,x)));
        }

        public int PopSmallest()
        {
            int smallest = pq.Dequeue();
            while (pq.Count > 0 && pq.Peek() == smallest)
                pq.Dequeue();

            return smallest;
        }

        public void AddBack(int num)
        {
            pq.Enqueue(num, num);
        }
    }
}
