using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC877_Stone_Game
    {
        public static void Start()
        {
            Console.WriteLine("LC877_Stone_Game");



            int[] nums = { 6, 3, 96, 99 };
            int[] nums2 = { 2, 2, 3, 3 };
            int num = 5;
            int num2 = 1;
            string str = "cba";
            string str2 = "abcd";

            var ans = StoneGame2(nums);


            //foreach ( var i in ans ) 
            //{
            //    Console.WriteLine(i.ToString());
            //}

            Console.WriteLine(ans);

        }
        //[6,3,9,9,3,8,8,7]
        //[6,3,9,9,3,8,8,7]
        //6,3,50,99
        //6
        //7

        //Input: piles = [3,7,2,3]
        //Output: true
        //此方法不行，會有例外
        static bool StoneGame(int[] piles)
        {  
            List<int> list = new (piles);
            List<int> dp = new ();
            int alice = 0;
            int bob = 0;
            int truns = 0;
            int stones;
            
            while (list.Count > 1) 
            {
                if (list[list.Count - 1] - list[list.Count - 2] > list[0] - list[1])
                {
                    stones = list[list.Count - 1];
                    list.RemoveAt(list.Count - 1);
                }
                else if(list[list.Count - 1] - list[list.Count - 2] < list[0] - list[1])
                {
                    stones = list[0];
                    list.RemoveAt(0);
                }
                else
                {
                    if (list[list.Count - 1] > list[0])
                    {
                        stones = list[list.Count - 1];
                        list.RemoveAt(list.Count - 1);
                    }
                    else
                    {
                        stones = list[0];
                        list.RemoveAt(0);
                    }
                }

                if (truns == 0)
                {
                    alice += stones;
                    truns = 1;
                }
                else
                {
                    bob += stones;
                    truns = 0;
                }
            }


            if (truns == 0)
            {
                alice += list[0];
            }
            else
            {
                bob += list[0];
            }

            return alice > bob ;
        }

        static bool StoneGame2(int[] piles)
        {
            return true;
        }

    }



}
