using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC136_Single_Number
    {
        public static void Start()
        {
            Console.WriteLine("LC136_Single_Number");

            int[] ints = { 2, 2, 1 };
            var ans = SingleNumber(ints);
            Console.WriteLine(ans.ToString());

            //foreach ( var val in valList) 
            //{
            //    //Console.WriteLine($"{val.ToString()}");
            //}



        }
        //Input: nums = [2,2,1]
        //Output: 1
        static int SingleNumber(int[] nums)
        {
            Dictionary<int, int> dic = new();

            for (int i = 0; i < nums.Length; i++)
            {

                if (dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]]++;
                }
                else
                {
                    dic.Add(nums[i], 1);
                }

            }
            foreach (var item in dic)
            {
                if (item.Value == 1)
                {
                    return item.Key;
                }
            }
            return 0;
        }
    }


}
