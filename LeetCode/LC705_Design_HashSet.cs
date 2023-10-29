using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC705_Design_HashSet
    {
        public static void Start()
        {
            Console.WriteLine("LC705_Design_HashSet");

            //MyHashSet obj = new MyHashSet();
            //obj.Add(key);
            //obj.Remove(key);
            //bool param_3 = obj.Contains(key);


            MyHashSet myHashSet = new MyHashSet();
            myHashSet.Add(1);      // set = [1]
            myHashSet.Add(2);      // set = [1, 2]
            Console.WriteLine(myHashSet.Contains(1)); // return True
            Console.WriteLine(myHashSet.Contains(3)); // return False, (not found)
            myHashSet.Add(2);      // set = [1, 2]
            Console.WriteLine(myHashSet.Contains(2)); // return True
            myHashSet.Remove(2);   // set = [1]
            Console.WriteLine(myHashSet.Contains(2)); // return False, (already removed)

        }

    }

//    Input
//["MyHashSet", "add", "add", "contains", "contains", "add", "contains", "remove", "contains"]
//[[], [1], [2], [1], [3], [2], [2], [2], [2]]


    public class MyHashSet
    {
        List<int> list;
        public MyHashSet()
        {
            list = new List<int>();
        }

        public void Add(int key)
        {
            if (!list.Contains(key))
            {
                list.Add(key);
            }
            
        }

        public void Remove(int key)
        {
            list.Remove(key);

        }

        public bool Contains(int key)
        {
            return list.Contains(key);
        }
    }


}
