using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace LeetCode
{
    internal class WC412_Q2_Count_Almost_Equal_Pairs_I
    {
        public static void Start()
        {
            Console.WriteLine("WC412_Q2_Count_Almost_Equal_Pairs_I");


            //2,1,1,0,1,3,0,2,1,0,1,0,0,0
            //
           
            int[] nums = { 8, 12, 5, 5, 14, 3, 12, 3, 3, 6, 8, 20, 14, 3, 8 };


            var ans = CountPairs(nums);
            

            Console.WriteLine(ans);

        }


        //Input: nums = [3,12,30,17,21]
        //Output: 2

        //[1,1,1,1,1]
        //10

        //[8,12,5,5,14,3,12,3,3,6,8,20,14,3,8]
        //12
        static int CountPairs(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    IsEqual(nums[i], nums[j]);
                }
            }


            void IsEqual(int a, int b)
            {

                int c = 0;
                string s1 = a.ToString().Replace("0",""); 
                string s2 = b.ToString().Replace("0","");

                if (s1.Length != s2.Length) 
                {
                    return;
                }
                if (s1.Length <= 2) 
                {
                    s1 = new string(s1.OrderBy(c => (int)c).ToArray());
                    s2 = new string(s2.OrderBy(c => (int)c).ToArray());

                    for (int i = 0; i < s1.Length; i++)
                    {
                        if (s1[i] != s2[i])
                        {
                            return;
                        }
                    }
                    count++;
                    return;
                }

                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] != s2[i])
                    {
                        c++;
                    }
                    if (c > 1)
                    {
                        return;
                    }
                }
                count++;
            }
            
            return count;
        }

    }



}
