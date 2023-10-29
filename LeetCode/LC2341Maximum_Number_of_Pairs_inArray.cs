using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC2341Maximum_Number_of_Pairs_inArray
    {
        public static void Start()
        {
            Console.WriteLine("LC2341Maximum_Number_of_Pairs_inArray");



            int[] nums = { 1, 3, 2, 1, 3, 2, 2 };

            var ans = NumberOfPairs(nums);


            foreach ( int i in ans ) 
            {

                Console.WriteLine(i.ToString());
            }

            //Console.WriteLine(5/3);

        }

        //Input: nums = [1,3,2,1,3,2,2]
        //Output: [3,1]
        public static int[] NumberOfPairs(int[] nums)
        {
            int[] ans = new int[2];


            Dictionary<int,int> map = new Dictionary<int,int>();

            foreach (int num in nums)
            {
                if (!map.TryAdd(num, 1))
                {
                    map[num]++;
                }
            }


            foreach (var i in map)
            {

                if (i.Value % 2 == 1)
                {
                    ans[1] ++;
   
                }
                ans[0] += i.Value / 2;
            }

            return ans;
        }

    }



}
