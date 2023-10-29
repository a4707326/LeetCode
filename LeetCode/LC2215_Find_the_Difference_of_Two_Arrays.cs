using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC2215_Find_the_Difference_of_Two_Arrays
    {
        public static void Start()
        {
            Console.WriteLine("LC2215_Find_the_Difference_of_Two_Arrays");


            var input1 = new int[] { 1, 2, 3, 3 };
            var input2 = new int[] { 1, 1, 2, 2 };



            var ans = FindDifference2(input1, input2);

            foreach (var item in ans)
            {
                Console.WriteLine(item.ToString());
                foreach (var item2 in item)
                {
                    Console.WriteLine(item2.ToString());
                }

            }


        }

        //Input: nums1 = [1,2,3], nums2 = [2,4,6]
        //Output: [[1,3],[4,6]]

        //Input: nums1 = [1,2,3,3], nums2 = [1,1,2,2]
        //Output: [[3],[]]
        public static IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            List<IList<int>> ans = new(); 

            ans.Add(nums1.Distinct().ToList());
            ans.Add(nums2.Distinct().ToList());

            for (int i = 0; i < nums2.Length; i++)
            {
                if (nums1.Contains(nums2[i]))
                {
                    ans[0].Remove(nums2[i]);
                }

            }

            for (int i = 0; i < nums1.Length; i++)
            {
                if (nums2.Contains(nums1[i]))
                {
                    ans[1].Remove(nums1[i]);
                }
            }
            return ans;
        }



        public static IList<IList<int>> FindDifference2(int[] nums1, int[] nums2)
        {
            HashSet<int> h1 = new (nums1), h2 = new (nums2);
            return new List<IList<int>> {
                h1.Where(x => !h2.Contains(x)).ToList<int>(),
                h2.Where(x => !h1.Contains(x)).ToList<int>()
            };
        }


    }

}
