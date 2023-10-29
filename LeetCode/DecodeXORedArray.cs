using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class DecodeXORedArray
    {
        public static void Start()
        {
            Console.WriteLine("DecodeXORedArray");

            var input = new int[] { 6, 2, 7, 3 };
            var input2 = 4;

            var ans = Solution(input, input2);

            foreach (int i in ans)
            {
                Console.WriteLine(i);
            }




        }

        //0000--0
        //0001--1
        //0010--2
        //0011--3
        //0100--4
        //0101--5
        //0110--6
        //0111--7

        //XOR
        //7 XOR 4 =
        //0111
        //0100
        //-----
        //0011 =3

        //XOR回推
        //7 XOR 3 =
        //0111
        //0011
        //-----
        //0100 =4

        //Input: encoded = [1,2,3], first = 1
        //Output: [1,0,2,1]
        //Explanation: If arr = [1,0,2,1], then first = 1 and encoded = [1 XOR 0, 0 XOR 2, 2 XOR 1] = [1,2,3]

        //Input: encoded = [6,2,7,3], first = 4
        //Output: [4,2,0,7,4]

        public static int[] Solution(int[] encoded, int first)
        {
            int[] result = new int[encoded.Length + 1];

            result[0] = first;

            for (int i = 1; i < result.Length; i++)
            {
                result[i] = result[i-1] ^ encoded[i-1];
            }
            return result;
        }

    }



}
