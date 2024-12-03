using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC34Find_First_and_Last_Position_of_Element_in_Sorted_Array
    {
        public static void Start()
        {
            Console.WriteLine("LC34Find_First_and_Last_Position_of_Element_in_Sorted_Array");




            int[] nums = { 5, 7, 7, 8, 8, 10 };

            int num = 7;


            var ans = SearchRange(nums, num);



            foreach (var i in ans)
            {
                Console.WriteLine(i.ToString());
            }

            //foreach (var i in ans)
            //{
            //    string a = "";
            //    foreach (var j in i)
            //    {
            //        a += j;

            //    }
            //    Console.WriteLine(a.ToString());
            //}

            Console.WriteLine(ans);

        }

        //Input: nums = [5,7,7,8,8,10], target = 8
        //Output: [3,4]
        //猜O(n),O(1)
        //答O(n),O(1)
        static int[] SearchRange(int[] nums, int target)
        {
            int first = -1; // Initialize first occurrence to -1
            int last = -1;  // Initialize last occurrence to -1

            // Iterate through the array
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    if (first == -1)
                    {
                        first = i; // Found the first occurrence
                    }
                    last = i; // Update last occurrence
                }
            }

            // Return the result as an array
            return new int[] { first, last };

        }

    }
}




