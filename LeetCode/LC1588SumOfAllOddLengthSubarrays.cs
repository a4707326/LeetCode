using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1588SumOfAllOddLengthSubarrays
    {
        public static void Start()
        {
            Console.WriteLine("LC1588SumOfAllOddLengthSubarrays");


            var input1 = new int[] { 10,11,12};




            var ans = SumOddLengthSubarrays3(input1);


            Console.WriteLine(ans.ToString());

        }
        //[10,11,12]
        //Input: arr = [1,4,2,5,3]
        //Output: 58
        public static int SumOddLengthSubarrays(int[] arr)
        {
            int sum = 0;
            int count = 0;
            int oddCount;


            oddCount = (arr.Length / 2)+1;



            for (int i = 0; i < oddCount; i++)//3
            {
                for (int j = 0; j < arr.Length - count; j++)//5 3 1
                {
                    for (int k = j; k < j + 1 + count; k++)
                    {

                        sum += arr[k];
                    }
                }
                count += 2;
            }

            return sum;
        }

        //效能可能比較差一點但更好閱讀，..為範圍運算子

        public static int SumOddLengthSubarrays2(int[] arr)
        {
            var sum = 0;
            for (var l = 1; l < arr.Length + 1; l += 2)
            {
                for (var i = 0; i < arr.Length - l + 1; i++)
                {
                    sum += arr[i..(i + l)].Sum();
                }
            }
            return sum;
        }



        //效能同1但，更精簡
        public static int SumOddLengthSubarrays3(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j += 2)
                {

                    for (int k = i; k <= j; k++)
                    {
                        sum += arr[k];
                    }

                }
            }
            return sum;
        }


    }



}
