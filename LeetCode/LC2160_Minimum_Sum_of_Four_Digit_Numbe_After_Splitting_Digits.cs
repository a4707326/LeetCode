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
    internal class LC2160_Minimum_Sum_of_Four_Digit_Numbe_After_Splitting_Digits
    {
        public static void Start()
        {



            Console.WriteLine("LC2160_Minimum_Sum_of_Four_Digit_Numbe_After_Splitting_Digits");

            int nums = 2932;


            var ans = MinimumSum2(nums);

            Console.WriteLine(ans);





        }

        //Input: num = 2932
        //Output: 52
        //猜O(n + log)
        //O(N log N)//Array.Sort()
        public static int MinimumSum(int num)
        {
            //分裂成4個
            //排序
            //index[0,2] + [0,3]

            string numString = num.ToString();
            int[] numArray = new int[numString.Length]; // 創建存放數字的數組    
            for (int i = 0; i < numString.Length; i++)
            {
                numArray[i] = int.Parse(numString[i].ToString());
            }
            
            Array.Sort(numArray);
            

            return (numArray[0] * 10 + numArray[2]) + (numArray[1] * 10 + numArray[3]);

        }

        //Input: num = 2932
        //Output: 52
        //O(N log N)
        public static int MinimumSum2(int num)
        {
            //分裂成4個
            //排序
            //index[0,2] + [0,3]

            int[] sortedDigits = num.ToString().OrderBy(x => x).Select(x => x - '0').ToArray();
            return (sortedDigits[0] * 10 + sortedDigits[2]) + (sortedDigits[1] * 10 + sortedDigits[3]);

        }
    }

}
