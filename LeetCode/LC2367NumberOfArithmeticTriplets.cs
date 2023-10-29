using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC2367NumberOfArithmeticTriplets
    {
        public static void Start()
        {
            Console.WriteLine("LC2367NumberOfArithmeticTriplets");


            var input1 = new int[] { 0, 1, 4, 6, 7, 10 };
            var input2 = 3;



            var ans = ArithmeticTriplets(input1, input2);

            Console.WriteLine(ans.ToString());

        }

        //Input: nums = [0,1,4,6,7,10], diff = 3
        //Output: 2

        public static int ArithmeticTriplets(int[] nums, int diff)
        {
            int annCount = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int count = 0;
                for (int j = 0+i; j < nums.Length ; j++)
                {
                    if (nums[j] == nums[i] + diff) 
                    {
                        count++;
                    }

                    if (nums[j] == nums[i] + (diff * 2))
                    {
                        annCount++;
                        System.Console.WriteLine(i.ToString());
                        break;
                    }

                    //if (nums[j] == nums[i] + (diff * 2))
                    //{
                    //    count++;
                    //}
                    //if (count == 2)
                    //{
                    //    annCount++;
                    //    //System.Console.WriteLine(i.ToString());
                    //    break;
                    //}

                }
            }


            return annCount;
        }


    }



}
