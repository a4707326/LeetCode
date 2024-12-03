using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC935_Knight_Dialer
    {
        public static void Start()
        {
            Console.WriteLine("LC935_Knight_Dialer");

            int num = 4;


            var ans = KnightDialer(num);


            Console.WriteLine(ans);

        }

        //Input: n = 2
        //Output: 20

        //答O(n),O(10)
        //演算法DP

        //20
        //[04, 06, 16, 18, 27, 29, 34, 38, 40, 43, 49, 60, 61, 67, 72, 76, 81, 83, 92, 94]
        //5不行跳，4跟6可以跳3個，其餘跳2個
        static int KnightDialer(int n)
        {
            int mod = 1_000_000_007;
            var arr = new long[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };//5的話會因為Copy覆蓋所以變成0
            var temp  = new long[10];//累積次數


            for (int i = 1; i < n; i++)
            {
                temp[0] = (arr[4] + arr[6]) % mod;
                temp[1] = (arr[6] + arr[8]) % mod;
                temp[2] = (arr[7] + arr[9]) % mod;
                temp[3] = (arr[4] + arr[8]) % mod;
                temp[4] = (arr[3] + arr[9] + arr[0]) % mod;
                temp[6] = (arr[1] + arr[7] + arr[0]) % mod;
                temp[7] = (arr[2] + arr[6]) % mod;
                temp[8] = (arr[1] + arr[3]) % mod;
                temp[9] = (arr[2] + arr[4]) % mod;

                Buffer.BlockCopy(temp, 0, arr, 0, temp.Length * sizeof(Int64));//將temp 同步給 arr
            }

            Int64 sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += (arr[i] % mod);
            }

            return (int)(sum % mod);
        }



    }



}
