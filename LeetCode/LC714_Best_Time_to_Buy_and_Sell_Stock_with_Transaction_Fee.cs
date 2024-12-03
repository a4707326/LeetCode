using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC714_Best_Time_to_Buy_and_Sell_Stock_with_Transaction_Fee
    {
        public static void Start()
        {
            Console.WriteLine("LC714_Best_Time_to_Buy_and_Sell_Stock_with_Transaction_Fee");




            int[] nums = { 1, 6, 3, 6, 9 };

            int num = 2;


            var ans = MaxProfit(nums, num);



            Console.WriteLine(ans);

        }

        //Input: prices = [1,3,2,8,4,9], fee = 2
        //Output: 8
        //Input: prices = [1,4,1,4,9], fee = 2 ,ot 1+6 =7
        //Input: prices = [1,6,3,6,9], fee = 2 ,ot 3+4 =7
        //猜O(n),O(1)
        //答O(n),O(1)
        //演算法Greedy
        static int MaxProfit(int[] prices, int fee)
        {
            int n = prices.Length;
            int maxProfit = 0;//累積利潤
            int minPrice = prices[0];//當前假定庫存最低價格(有利潤才買入)
            for (int i = 1; i < n; i++)
            {
                //判斷最低買入價格
                if (prices[i] < minPrice)
                { 
                    minPrice = prices[i];
                }
                else if(prices[i] - fee > minPrice)//如果當前價格 - 手續費 > 最低買入價格，表示有利潤
                {
                    maxProfit += prices[i] - fee - minPrice;//加上利潤
                    minPrice = prices[i] - fee;//比價賣出關鍵(利潤差)
                }
            }
            return maxProfit;
        }
    }



}
