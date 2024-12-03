using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class GB1
    {
        public static void Start()
        {
            int[] numbers = { 5, 3, 8, 4, 2 };

            Console.WriteLine("排序前:");
            Console.WriteLine(string.Join(", ", numbers));

            BubbleSort(numbers);

            Console.WriteLine("排序後:");
            Console.WriteLine(string.Join(", ", numbers));


            string str = "11";
            Test("11");
            Console.WriteLine(str);
        }




        static void BubbleSort(int[] nums)
        {
            int temp = 0;
            int n = nums.Length;
            for (int i = 0; i < n - 1  ; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
        }
        static void Test(string str)
        {
            str = "555";
        }

    }
}
