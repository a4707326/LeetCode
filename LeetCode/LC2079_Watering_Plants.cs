using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC2079_Watering_Plants
    {
        public static void Start()
        {
            Console.WriteLine("LC2079_Watering_Plants");



            int[] nums = { 2, 2, 3, 3 };
            int k = 5;

            var ans = WateringPlants(nums, k);


            //foreach ( int i in ans ) 
            //{
            //    Console.WriteLine(i.ToString());
            //}

            Console.WriteLine(ans);

        }

        //Input: plants = [2,2,3,3], capacity = 5
        //Output: 14
        static int WateringPlants(int[] plants, int capacity)
        {
            int nowWater = capacity;
            int step = 0;

            for (int i = 0; i < plants.Length; i++)
            {
                if (plants[i] > nowWater)
                {
                    step += i * 2;
                    nowWater = capacity;
                }
                nowWater -= plants[i];
                step++;
            }

            return step;
        }

    }



}
