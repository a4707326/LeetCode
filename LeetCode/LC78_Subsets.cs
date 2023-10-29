using System;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace LeetCode
{
    internal class LC78_Subsets
    {
        //public static List<List<int>> ans = new List<List<int>>();
        static List<IList<int>> result = new();
        public static void Start()
        {
            Console.WriteLine("LC78_Subsets");

            int[] nums = { 1, 2, 3, 4 };

            var ans = Subsets2(nums);


            foreach (var i in ans)
            {

                foreach (var j in i)
                {
                    Console.WriteLine(j);
                }
                Console.WriteLine(",");
            }


        }



        //Input: nums = [1,2,3]
        //Output: [[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]
        //未完成
        public static IList<IList<int>> Subsets(int[] nums)
        {
            HashSet<int> hash = new();

            DFS(nums, hash);

            return result;
        }
        //[]
        public static void DFS(int[] nums, HashSet<int> hash)
        {
            bool canAdd = true;

            //foreach (var item in result)
            //{  
            //    if (item.Count == hash.Count && item.Sum() == hash.Sum())
            //    {
            //        canAdd = false;
            //    }
            //}

            if (canAdd == true) 
            {
                result.Add(new List<int>(hash));
            }


            for (int i = 0; i < nums.Length; i++)
            {
                if (hash.Add(nums[i]))
                {
                    DFS(nums, hash);
                    hash.Remove(nums[i]);
                } 
            }

            if (hash.Count == nums.Length)
            {
                return;
            }

        }

        //時間複雜度是 O(2^N)，其中 N 是 nums 數組的長度。
        public static IList<IList<int>> Subsets2(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();
            backtrack(result, new List<int>(), nums, 0);
            return result;
        }
        //[],1,12,123,1234,124,13,14,134,2,23,234,24,3
        static void backtrack(List<IList<int>> result, List<int> sub, int[] nums, int start)
        {
            result.Add(new List<int>(sub));
            for (int i = start; i < nums.Length; i++)
            {
                sub.Add(nums[i]);
                backtrack(result, sub, nums, i + 1);
                sub.RemoveAt(sub.Count - 1);
            }
        }


    }
}
