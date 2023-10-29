using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC2024_Maximize_the_Confusion_of_an_Exam
    {
        public static void Start()
        {
            Console.WriteLine("LC2024_Maximize_the_Confusion_of_an_Exam");
            //"FFFFTTFTTT";//TFTTT
            string answerKey = "FFTFTTTFFF";
            int k = 1;

            var ans = MaxConsecutiveAnswers2(answerKey, k);

            Console.WriteLine(ans.ToString());



        }

        //Input: answerKey = "TTFF", k = 3
        //Output: 4
        public static int MaxConsecutiveAnswers(string answerKey, int k)
        {

            int tCount = 0;
            int fCount = 0;
            for (int i = 0; i < answerKey.Length; i++)
            {
                if (answerKey[i] == 'T')
                {
                    tCount++;
                }
                else
                {
                    fCount++;
                }
            }
            if (tCount <= k || fCount <= k)
            {
                return answerKey.Length;
            }

            int left = 0;
            int count = 0;
            int max = 0;
            int cTimes = 0;
            int cIndex = 0;

            for (int i = 0; i < answerKey.Length; i++)
            {
                if (answerKey[i] == answerKey[left])
                {
                    count++;
                }
                else if (cTimes < k)
                {
                    cTimes++;
                    count++;
                    if (cTimes == 1)
                    {
                        cIndex = i;
                    }
                }
                else
                {
                    i = cIndex - 1;
                    left = cIndex;
                    int diff = k - cTimes;
                    if (count + diff > max) max = count + diff;
                    count = 0;
                    cTimes = 0;
                }


                if (i == answerKey.Length - 1)
                {
                    int diff = k - cTimes;
                    if (count + diff > max) max = count + diff;
                }

            }




            return max;
        }

        //Input: answerKey = "TTFF", k = 3
        //Output: 4
        public static int MaxConsecutiveAnswers2(string answerKey, int k)
        {
            int left = 0;
            int tCount = 0;
            int fCount = 0;
            int max = 0;

            for (int right = 0; right < answerKey.Length; right++)
            {
                if (answerKey[right] == 'T')
                {
                    tCount++;
                }
                else
                {
                    fCount++;
                }

                if (Math.Min(tCount, fCount) > k)
                {
                    if (answerKey[left] == 'T')
                    {
                        tCount--;
                    }
                    else
                    {
                        fCount--;
                    }
                    left++;
                }

                max = Math.Max(max, right - left + 1);
            }

            return max;
        }

        public static int MaxConsecutiveAnswers3(string answerKey, int k)
        {
            int longestConsecutiveCount = 0;  // Maximum number of consecutive 'T's or 'F's
            int left = 0;  // Left pointer of the sliding window
            int maxChanges = k;  // Maximum changes allowed
            int tCount = 0;  // Count of consecutive 'T's
            int fCount = 0;  // Count of consecutive 'F's

            // Iterate through the answerKey using the right pointer
            for (int right = 0; right < answerKey.Length; right++)
            {
                char currentAnswer = answerKey[right];

                // Increment the count of the current answer
                if (currentAnswer == 'T')
                {
                    tCount++;
                }
                else
                {
                    fCount++;
                }

                // If the number of changes needed exceeds the maximum changes allowed,
                // move the left pointer and update the counts
                if (Math.Min(tCount, fCount) > maxChanges)
                {
                    char leftAnswer = answerKey[left];

                    // Decrement the count of the left answer and move the left pointer
                    if (leftAnswer == 'T')
                    {
                        tCount--;
                    }
                    else
                    {
                        fCount--;
                    }

                    left++;  // Move the left pointer
                }

                // Update the longest consecutive count
                longestConsecutiveCount = Math.Max(longestConsecutiveCount, right - left + 1);
            }

            return longestConsecutiveCount;

        }
    }


}
