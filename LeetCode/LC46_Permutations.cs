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
    internal class LC46_Permutations
    {
        //public static List<List<int>> ans = new List<List<int>>();
        static List<IList<int>> result = new();
        public static void Start()
        {
            Console.WriteLine("LC46_Permutations");

            int[] nums = { 1, 2, 3 };

            var ans = Permute2(nums);


            foreach (var i in ans)
            {

                foreach (var j in i)
                {
                    Console.WriteLine(j);
                }
                Console.WriteLine(",");
            }


        }


        //[1,2]2 = 1*2
        //[1,2,3] 6 = 1*2*3
        //[1,2,3,4] 24 = 1*2*3*4
        //Input: nums = [1,2,3]
        //Output: [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]

        //複雜度：O(N×N!)，還看不是很懂
        public static IList<IList<int>> Permute(int[] nums)
        {
            List<IList<int>> ans = new ();

            DFS(nums, 0,ans);

            return ans;
        }

        //123,0
        //123,1
        //123,2
        //123,3 add
        //r 2 2
        //132 1

        //[123]


        static void DFS(int[] nums, int start, List<IList<int>> ans) 
        {
            if (start == nums.Length)
            {
                ans.Add(new List<int>(nums));
                return;
            }
            for (int i = start; i < nums.Length; i++)
            {
                Swap(nums, start, i);
                DFS(nums, start +1 , ans);
                Swap(nums, start, i);//回朔
            }

        }


        static void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }




        //時間複雜度是 O(N * N!) ，比較簡單
        public static IList<IList<int>> Permute2(int[] nums)
        {
            BackTrack(new HashSet<int>(), nums);
            return result;
        }

        public static void BackTrack(HashSet<int> curr, int[] nums)
        {
            if (curr.Count == nums.Length)
            {
                result.Add(new List<int>(curr));
                return;
            }

            foreach (int num in nums)
            {
                if (curr.Add(num))
                {
                    BackTrack(curr, nums);
                    curr.Remove(num);
                }
            }
        }

    }


}
