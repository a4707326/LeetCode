using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC121_Best_Time_to_Buy_and_Sell_Stock
    {
        public static void Start()
        {
            Console.WriteLine("LC121_Best_Time_to_Buy_and_Sell_Stock");



            int[] nums = { 7, 6, 4, 3, 1 };


            var ans = MaxProfit(nums);


            Console.WriteLine(ans);

        }
        //Input: prices = [2,9,1,1,1,1]
        //Input: prices = [2,4,1,6,1,1]
        //Input: prices = [2,4,1,2,1,1]
        //Input: prices = [2,4,5,8,1,1]

        //Input: prices = [7,1,5,3,6,4]
        //Output: 5

        //Input: prices = [7,6,4,3,1]
        //Output: 0
        static int MaxProfit(int[] prices)
        {
            int min = prices[0];
            int profit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                profit = Math.Max(prices[i] - min, profit);
                
                min = Math.Min(prices[i],min);

            }
           
            return profit;

        }



    }



}
