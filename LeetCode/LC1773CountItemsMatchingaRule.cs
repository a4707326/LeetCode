using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1773CountItemsMatchingaRule
    {
        public static void Start()
        {
            Console.WriteLine("LC1773CountItemsMatchingaRule");
            //IList<IList<string>> input = new List<IList<string>>

            IList<IList<string>> input = new List<IList<string>>
            {
                new List<string> { "phone", "blue", "pixel" },
                new List<string> { "computer", "silver", "lenovo"},
                new List<string> { "phone", "gold", "iphone" }
            };

            var input2 = "color";
            var input3 = "silver";



            var ans = CountMatches(input, input2, input3);

            Console.WriteLine(ans.ToString());

        }


        //Input: items = [["phone","blue","pixel"],["computer","silver","lenovo"],["phone","gold","iphone"]], ruleKey = "color", ruleValue = "silver"
        //Output: 1
        //Explanation: There is only one item matching the given rule, which is ["computer","silver","lenovo"].

        public static int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            int count = 0;
            int index = 0;

            foreach (var item in items) 
            {
                if (ruleKey == "type")
                {
                    index = 0;
                }
                if (ruleKey == "color")
                {
                    index = 1;
                }
                if (ruleKey == "name")
                {
                    index = 2;
                }

                if (item[index] == ruleValue)
                {
                    count++;
                }
            }


            return count;
        }


    }



}
