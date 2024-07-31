using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC670_Maximum_Swap
    {
        public static void Start()
        {
            Console.WriteLine("LC670_Maximum_Swap");


            int num = 1993;


            var ans = MaximumSwap(num);



            Console.WriteLine(ans);

        }
        //Input: num = 2736
        //Output: 7236
        static int MaximumSwap(int num)
        {
            string str = num.ToString();
            int[] nums = str.Select(c => c - '0').ToArray();

            int[] numsSorted = nums.ToArray();
            Array.Sort(numsSorted);
            Array.Reverse(numsSorted);


            int max = 0;
            int index = -1;
            int index2 = -1;


            for (int i = 0; i < nums.Length; i++)
            {

                if (index == -1)
                {
                    if (nums[i] != numsSorted[i])
                    {
                        index = i;
                    }
                }
                else
                {
                    if (nums[i] >= max)
                    {
                        max = nums[i];
                        index2 = i;
                    }
                }


            }

            //防呆
            if (index2 == -1 || index == -1)
            {
                return num;
            }

            //交換
            int temp = nums[index];
            nums[index] = nums[index2];
            nums[index2] = temp;


            //轉回int
            int ArrayToInt(int[] array)
            {
                string numberStr = string.Join("", array);
                int number = int.Parse(numberStr);
                return number;
            }

            return ArrayToInt(nums);
        }

    }



}
