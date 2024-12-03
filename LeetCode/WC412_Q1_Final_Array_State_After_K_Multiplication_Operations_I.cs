using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class WC412_Q1_Final_Array_State_After_K_Multiplication_Operations_I
    {
        public static void Start()
        {
            Console.WriteLine("WC412_Q1_Final_Array_State_After_K_Multiplication_Operations_I");


            int[] nums = { 7, 71, 15 };

            int num = 10;
            int num2 = 3;


            var ans = GetFinalState(nums, num, num2);



            foreach (var i in ans)
            {
                Console.WriteLine(i.ToString());
            }

            //for (int i = 0; i < nums.Length; i++)
            //{

            //}
            ////foreach (var i in ans)
            ////{
            ////    string a = "";
            ////    foreach (var j in i)
            ////    {
            ////        a += j;

            ////    }
            ////    Console.WriteLine(a.ToString());
            ////}

            //Console.WriteLine(ans);

        }

        //Input: nums = [2,1,3,5,6], k = 5, multiplier = 2
        //Output: [8,4,6,5,6]
        static int[] GetFinalState(int[] nums, int k, int multiplier)
        {

            for (int i = 0; i < k; i++)
            {
                Mul();
            }

            void Mul() 
            {
                int minIdx = -1;
                int min = 2147483647;
                for (var i = 0; i < nums.Length; i++)
                {
                    if (nums[i] < min)
                    {
                        min = nums[i];
                        minIdx = i;
                    }
                }
                nums[minIdx] *= multiplier;
            }

            return nums;
        }
    }

}



