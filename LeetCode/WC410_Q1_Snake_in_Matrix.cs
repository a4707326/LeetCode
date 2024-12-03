using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class WC410_Q1_Snake_in_Matrix
    {
        public static void Start()
        {
            Console.WriteLine("WC410_Q1_Snake_in_Matrix");




            int num = 3;
  
            string[] strs = { "DOWN", "RIGHT", "UP" };

            var ans = FinalPositionOfSnake( num, strs);

            Console.WriteLine(ans);

        }
        //Input: n = 3, commands = ["DOWN","RIGHT","UP"]

        //Output: 1
        static int FinalPositionOfSnake(int n, IList<string> commands)
        {
            int[,] m = new int[n, n];
            int x = 0;
            int y = 0;

            for (int i = 0; i < n; i++) // 遍歷行
            {
                for (int j = 0; j < n; j++) // 遍歷列
                {
                    m[i, j] = (n*i) + j;
                }
            }

            for (int i = 0; i < commands.Count(); i++)
            {
                if (commands[i] == "UP")
                {
                    if (y > 0)
                    {
                        y--;
                    }

                }
                else if (commands[i] == "DOWN")
                {

                    if (y < n - 1)
                    {
                        y++;
                    }
                }
                else if (commands[i] == "LEFT")
                {
                    if (x > 0)
                    {
                        x--;
                    }
                }
                else if (commands[i] == "RIGHT")
                {
                    if (x < n - 1)
                    {
                        x++;
                    }
                }

            }

            return m[y,x];
        }


    }



}
