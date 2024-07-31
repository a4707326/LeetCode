using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC495_Teemo_Attacking
    {
        public static void Start()
        {
            Console.WriteLine("LC495_Teemo_Attacking");



            int[] nums = { 1,2 };

            int num = 2;


            var ans = FindPoisonedDuration(nums, num);



            Console.WriteLine(ans);

        }

        //Input: timeSeries = [1,2], duration = 2
        //Output: 3
        static int FindPoisonedDuration(int[] timeSeries, int duration)
        {
            int time = duration;//因為最後一個一定是完整的時間
            for (int i = 0; i < timeSeries.Length - 1; i++)
            {
                int diff = timeSeries[i + 1] - timeSeries[i];
                if (diff >= duration)
                {
                    time += duration;
                }
                else if (diff > 0) 
                {
                    time += diff;
                }
            }
            return time;
        }

    }



}
