using System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC169_Majority_Element
    {
        public static void Start()
        {
            Console.WriteLine("LC169_Majority_Element");

            int[] nums = { 3, 3, 4 };

            var ans = MajorityElement(nums);

            Console.WriteLine(ans);



        }

        //Input: nums = [3,2,3]
        //Output: 3
        //猜O(2n),O(n)
        //實際O(n),O(n)//這是因為在算法分析中，我們更關心的是時間複雜度的增長趨勢，而不是精確的數值。所以在這個情況下，我們可以簡單地表示為 O(N)。
        public static int MajorityElement(int[] nums)
        {
            //dict 存每個數字的數量
            //取最多

            Dictionary<int,int> dict = new();

            foreach (int i in nums) 
            {

                if (!dict.TryAdd(i,1))
                {
                    dict[i]++;
                }
            }

            return dict.MaxBy(x => x.Value).Key;//O(n)
        }





    }


}
