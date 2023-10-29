using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Concatenation_of_Array
    {


        public static void Start()
        {
            Console.WriteLine("Concatenation_of_Array");

            var ints = GetConcatenation(new int[] { 1,3,2,1 });
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }


        }

        //1 3 2 1
        //1 3 2 1 1 3 2 1 
        public static int[] GetConcatenation(int[] nums)
        {
            int[] result = new int[nums.Length * 2];
            
 
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = nums[i];
                result[i + nums.Length] = nums[i];
            }


            return result;
        }
    }
}
