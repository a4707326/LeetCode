using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1539_Kth_Missing_Positive_Number
    {
        public static void Start()
        {
            Console.WriteLine("LC1539_Kth Missing_Positive_Number");

            int[] arr = { 2, 3, 4, 7, 11 };

            int k = 5;

            var ans = FindKthPositive(arr, k);

            Console.WriteLine(ans.ToString());

            //foreach (int i in ans)
            //{
            //    Console.WriteLine(i.ToString());
            //}


        }

        //L,0
        //R,4
        //M,2 =4
        //

        //Input: arr = [2,3,4,7,11], k = 5
        //Output: 9
        public static int FindKthPositive(int[] arr, int k)
        {
            //從1開始判斷是否為miss，找到5個miss就是ans，如果判斷完所有arr之後就都是miss
            int i = 0;
            int ans = 0;
            int miss = 0;
            while (miss < k) 
            {
                ans++;
                if (arr[i] != ans)
                {
                    miss++;
                }
                else if (i < arr.Length-1)//碰到不是miss的就跳過 不加miss
                {
                    i++;
                    
                }
            }
            return ans;
        }
    }



}

