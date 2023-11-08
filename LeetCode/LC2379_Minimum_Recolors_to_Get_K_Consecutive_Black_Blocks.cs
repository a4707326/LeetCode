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
    internal class LC2379_Minimum_Recolors_to_Get_K_Consecutive_Black_Blocks
    {
        public static void Start()
        {
            Console.WriteLine("LC2379_Minimum_Recolors_to_Get_K_Consecutive_Black_Blocks");

            string blocks = "WBBWWBBWBW";
            int k = 7;


            int num = 2;
            string binary = Convert.ToString(num, 2);//轉2進制
            int decimalNumber = Convert.ToInt32(binary, 2); //轉10進制


            Console.WriteLine(decimalNumber);

            var ans = MinimumRecolors2(blocks,k);

            //Console.WriteLine(ans);

        }

        //Input: blocks = "WBBWWBBWBW", k = 7
        //Output: 3
        //猜O (N * M)
        //O(N * M)
        //Sliding Window
        //LC
        public static int MinimumRecolors(string blocks, int k)
        {

            int min = 101;
            for (int i = k; i <= blocks.Length; i++)
            {
                int count = 0;
                for (int j = i - k; j < i; j++)
                {
                    if (blocks[j] == 'W') count++;
                }
                if (count < min) min = count;
            }
            return min;
        }

        //Input: blocks = "WBBWWBBWBW", k = 7
        //Output: 3
        //O(N)
        //Sliding Window
        public static int MinimumRecolors2(string blocks, int k)
        {
            int left = 0, right = 0;
            int whiteCount = 0; // 窗口內的白色數量
            int minRecolors = int.MaxValue; // 最小的白色次數

            while (right < blocks.Length)
            {
                
                if (blocks[right] == 'W')
                {
                    whiteCount++;//紀錄
                }
                right++;// 擴大窗口

                if (right - left == k)//當前窗口符合大小K
                {
                    minRecolors = Math.Min(minRecolors, whiteCount);
                    if (blocks[left] == 'W')
                    {
                        whiteCount--;
                    }
                    left++;//縮小窗口
                }

            }
            // 如果 minRecolors 沒有被更新過，返回 0，否則返回 minRecolors
            return minRecolors == int.MaxValue ? 0 : minRecolors;
        }
        //WBBWWBBWBW
        //WBBWWBBWB
        //R9
        //L0
        //BC5 

        //min 
    }


}
