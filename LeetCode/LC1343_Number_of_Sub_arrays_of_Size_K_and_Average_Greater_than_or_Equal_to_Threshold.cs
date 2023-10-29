using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1343_Number_of_Sub_arrays_of_Size_K_and_Average_Greater_than_or_Equal_to_Threshold
    {
        public static void Start()
        {
            Console.WriteLine("LC1343_Number_of_Sub_arrays_of_Size_K_and_Average_Greater_than_or_Equal_to_Thresholdㄋ");

            int[] arr = { 2, 2, 2, 2, 5, 5, 5, 8 };

            int k = 3;
            int thresholdk = 4;

            var ans = NumOfSubarrays2(arr, k,thresholdk);
            Console.WriteLine(ans.ToString());




        }

        //Input: arr = [2,2,2,2,5,5,5,8], k = 3, threshold = 4
        //Output: 3
        public static int NumOfSubarrays(int[] arr, int k, int threshold)
        {
            int avg;
            int count = 0;

            for (int i = 0; i < arr.Length - k +1 ; i++)
            {
                avg = 0;
                for (int j = i; j < k + i; j++)
                {
                    avg += arr[j];
                }
                if (avg / k >= threshold)
                {
                    count++;
                }
            }

            return count;
        }

        //[11,13,17,23,29,31,7,5,2,3]
        public static int NumOfSubarrays2(int[] arr, int k, int threshold)
        {
            int j = 0;//左指標
            var sum = 0;
            var count = 0;

            for (int i = 0; i < arr.Length; i++)//i 為右指標
            {
                sum += arr[i];

                if (i - j  ==  k - 1)
                {
                    if (sum / k >= threshold)
                    {
                        count++;
                    }
                    sum -= arr[j++] ;
                }
            }

            return count;
        }






    }


}
