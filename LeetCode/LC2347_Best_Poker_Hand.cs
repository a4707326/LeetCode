using System;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC2347_Best_Poker_Hand
    {
        public static void Start()
        {
            Console.WriteLine("LC2347_Best_Poker_Hand");

            int[] ranks = { 13, 2, 1, 1, 1 };
            char[] suits = { 'a', 'a', 'a', 'a', 'b' };

            var ans = BestHand(ranks, suits);

            Console.WriteLine(ans);


        }
        //Input: ranks = [13,2,3,1,9], suits = ["a","a","a","a","a"]
        //Output: "Flush"
        public static string BestHand(int[] ranks, char[] suits)
        {
            //1.先判斷所有花色是否一致
            //2.判斷有幾個Rank 相同

            //1.先判斷所有花色是否一致
            bool isSameSuit = true;
            for (int i = 1; i < suits.Length; i++)
            {
                if (suits[i] != suits[i - 1])
                {
                    isSameSuit = false;
                    break;
                }
            }
            if (isSameSuit == true) return "Flush";

            Dictionary<int, int> ranksDict = new();

            for (int i = 0; i < ranks.Length; i++)
            {
                if (!ranksDict.TryAdd(ranks[i], 1))
                {
                    ranksDict[ranks[i]]++;
                }
            }

            int maxRankCount = ranksDict.Max(x => x.Value);

            if (maxRankCount >= 3)
            {
                return "Three of a Kind";
            }
            if (maxRankCount == 2)
            {
                return "Pair";
            }

            return "High Card";

        }







    }


}
