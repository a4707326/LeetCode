using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1472_Design_Browser_History
    {
        public static void Start()
        {
            Console.WriteLine("LC1472_Design_Browser_History");

            //BrowserHistory obj = new BrowserHistory("leetcode.com");
            //obj.Visit("google.com");
            //obj.Visit("facebook.com");
            //obj.Visit("youtube.com");
            //string param_2 = obj.Back(1);
            //string param_3 = obj.Back(1);
            //string param_4 = obj.Forward(1);
            //obj.Visit("linkedin.com");
            //string param_5 = obj.Forward(2);
            //string param_6 = obj.Back(2);
            //string param_7 = obj.Back(7);

            //BrowserHistory browserHistory = new BrowserHistory("leetcode.com");
            //browserHistory.Visit("google.com");       // You are in "leetcode.com". Visit "google.com"
            //browserHistory.Visit("facebook.com");     // You are in "google.com". Visit "facebook.com"
            //browserHistory.Visit("youtube.com");      // You are in "facebook.com". Visit "youtube.com"
            //browserHistory.Back(1);                   // You are in "youtube.com", move back to "facebook.com" return "facebook.com"
            //browserHistory.Back(1);                   // You are in "facebook.com", move back to "google.com" return "google.com"
            //browserHistory.Forward(1);                // You are in "google.com", move forward to "facebook.com" return "facebook.com"
            //browserHistory.Visit("linkedin.com");     // You are in "facebook.com". Visit "linkedin.com"
            //browserHistory.Forward(2);                // You are in "linkedin.com", you cannot move forward any steps.
            //browserHistory.Back(2);                   // You are in "linkedin.com", move back two steps to "facebook.com" then to "google.com". return "google.com"
            //browserHistory.Back(7);                   // You are in "google.com", you can move back only one step to "leetcode.com". return "leetcode.com"

            BrowserHistory obj = new BrowserHistory("jrbilt.com");
            obj.Visit("uiza.com");
            obj.Forward(3);
            obj.Forward(3);
            obj.Visit("fveyl.com");
            obj.Visit("hyhqfqf.com");//
            obj.Back(3);
            obj.Visit("cccs.com");//jrbilt.com,cccs.com
            obj.Visit("bivz.com");
            obj.Forward(6);
            obj.Back(1);
            obj.Visit("cmbw.com");
            obj.Visit("iywwwfn.com");
            obj.Visit("sktbhdx.com");
            obj.Forward(8);
            obj.Forward(10);
            obj.Visit("bskj.com");
            obj.Visit("thw.com");
            obj.Back(6);
            obj.Visit("hgesj.com");
            obj.Forward(6);
            obj.Visit("ctb.com");
            obj.Visit("fllnc.com");
            obj.Visit("fs.com");
            obj.Back(7);
        }

    }




    //        Input:
    //["BrowserHistory","visit","visit","visit","back","back","forward","visit","forward","back","back"]
    //        [["leetcode.com"],["google.com"],["facebook.com"],["youtube.com"],[1],[1],[1],["linkedin.com"],[2],[2],[7]]


    //[null,null,null,null,"facebook.com","google.com","facebook.com",null,"linkedin.com","google.com","leetcode.com"]
    //["leetcode.com",google.com,facebook.com,youtube.com,linkedin.com]//3
    public class BrowserHistory
    {
        List<string> list;
        int curIdx = 0;
        public BrowserHistory(string homepage)
        {
            list = new List<string>();
            list.Add(homepage);
        }

        public void Visit(string url)
        {

            list.RemoveRange(curIdx + 1, list.Count - (curIdx +1));
            list.Add(url);
            curIdx = list.Count - 1;
        }

        public string Back(int steps)
        {
            string url;
            if (curIdx - steps < 0 )
            {
                curIdx = 0;
            }
            else
            {
                curIdx -= steps;
            }

            url = list[curIdx];
            //Console.WriteLine(url);
            return url;
        }

        public string Forward(int steps)
        {
            string url;
            if (curIdx + steps > list.Count -1)
            {
                curIdx = list.Count -1;
            }
            else
            {
                curIdx += steps;
            }
            url = list[curIdx];
            //Console.WriteLine(url);
            return url;

        }
    }

//    以下是您的 BrowserHistory 类中各个方法的时间复杂度分析：

//Visit(string url) 方法：

//时间复杂度：O(1)
//这个方法只涉及添加一个新的网页 URL 到列表中，因此不受列表大小的影响。
//Back(int steps) 方法：

//时间复杂度：O(1)
//这个方法只涉及根据 steps 的值更新 curIdx，然后返回相应位置的网页 URL。不需要遍历列表。
//Forward(int steps) 方法：

//时间复杂度：O(1)
//类似于 Back 方法，这个方法只涉及根据 steps 的值更新 curIdx，然后返回相应位置的网页 URL。
//总体来说，这些方法的时间复杂度都是常数级别的，不受访问历史记录的大小影响。这是因为它们只需要基于当前位置和输入步数来计算新的位置，而不需要遍历整个历史记录列表。

//空间复杂度是 O(N)，其中 N 是访问的网页数量，因为您在 list 中保存了整个历史记录。


}
