using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1475_Final_Prices_With_a_Special_Discount_in_a_Shop
    {
        public static void Start()
        {
            Console.WriteLine("LC1475_Final_Prices_With_a_Special_Discount_in_a_Shop");

            int[] nums = { 10, 1, 1, 6 };

            var ans = FinalPrices(nums);


            foreach (int i in ans) 
            {
                Console.WriteLine(i.ToString());
            }


        }
        //10,1,1,6
        //Input: prices = [8,4,6,2,3]
        //Output: [4,2,4,2,3]
        public static int[] FinalPrices(int[] prices)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = 1 + i; j < prices.Length; j++)
                {
                    if (prices[j] <= prices[i])
                    {
                        prices[i] -= prices[j];
                        break;
                    }
                }
            }
            return prices;
        }
    }


}
