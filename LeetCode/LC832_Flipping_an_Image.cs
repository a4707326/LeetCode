using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC832_Flipping_an_Image
    {
        public static void Start()
        {
            Console.WriteLine("LC832_Flipping_an_Image");


            int[][] input1 = {
                new int[] { 1,1,0},
                new int[] { 1,0,1},
                new int[] { 0,0,0},
            };




            var ans = FlipAndInvertImage2(input1);

            foreach (var item in ans)
            {
                foreach (var item2 in item)
                {
                    Console.WriteLine(item2.ToString());
                }
            }


        }
        //Input: image = [[1,1,0],[1,0,1],[0,0,0]]
        //Output: [[1,0,0],[0,1,0],[1,1,1]]
        public static int[][] FlipAndInvertImage(int[][] image)
        {
            int[][] ints = new int[image.Length][];

            for (int i = 0; i < image.Length; i++)
            {
                ints[i] = new int[image[0].Length]; // 初始化每個內部的 int[] 陣列

                for (int j = 0; j < image[i].Length; j++)
                {
                    if (image[i][j] == 0)
                    {
                         ints[i][j] = 1;
                    }
                    else
                    {
                        ints[i][j] = 0;
                    }

                }
                Array.Reverse(ints[i]);
            }

            return ints;
        }

        public static int[][] FlipAndInvertImage2(int[][] image)
        {
            for (int i = 0; i < image.Length; i++)
            {
                Array.Reverse(image[i]);
            }
            for (int i = 0; i < image.Length; i++)
            {
                for (int j = 0; j < image[i].Length; j++)
                {
                    image[i][j] = 1 ^ image[i][j];
                }
            }
            return image;
        }



    }



}
