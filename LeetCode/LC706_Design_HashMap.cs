using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC706_Design_HashMap
    {
        public static void Start()
        {
            Console.WriteLine("LC706_Design_HashMap");



            //MyHashMap myHashMap = new MyHashMap();
            //myHashMap.Put(1, 1); // The map is now [[1,1]]
            //myHashMap.Put(2, 2); // The map is now [[1,1], [2,2]]
            //Console.WriteLine(myHashMap.Get(1));    // return 1, The map is now [[1,1], [2,2]]
            //Console.WriteLine(myHashMap.Get(3));    // return -1 (i.e., not found), The map is now [[1,1], [2,2]]
            //myHashMap.Put(2, 1); // The map is now [[1,1], [2,1]] (i.e., update the existing value)
            //Console.WriteLine(myHashMap.Get(2));    // return 1, The map is now [[1,1], [2,1]]
            //myHashMap.Remove(2); // remove the mapping for 2, The map is now [[1,1]]
            //Console.WriteLine(myHashMap.Get(2));    // return -1 (i.e., not found), The map is now [[1,1]]
            //myHashMap.Put(5, 5);
            //myHashMap.Put(2, 7);
            //Console.WriteLine(myHashMap.Get(2));
            //Console.WriteLine(myHashMap.Get(5));
            ////1,-1,1,-1



            MyHashMap hashMap = new MyHashMap();
            hashMap.Remove(27);
            hashMap.Put(65, 65);
            hashMap.Remove(19);
            hashMap.Remove(0);
            int val1 = hashMap.Get(18);
            Console.WriteLine(val1);
            hashMap.Remove(3);
            hashMap.Put(42, 0);
            int val2 = hashMap.Get(19);
            Console.WriteLine(val2);
            hashMap.Remove(42);
            hashMap.Put(17, 90);//

            int val3 = hashMap.Get(17);
            Console.WriteLine(val3);

            //hashMap.Put(31, 76);
            //hashMap.Put(48, 71);
            //hashMap.Put(5, 50);
            //hashMap.Put(7, 68);
            //hashMap.Put(73, 74);
            //hashMap.Put(85, 18);
            //hashMap.Put(74, 95);
            //hashMap.Put(84, 82);
            //hashMap.Put(59, 29);
            //hashMap.Put(71, 71);
            //hashMap.Remove(42);
            //hashMap.Put(51, 40);
            //hashMap.Put(33, 76);
            //int val3 = hashMap.Get(17);//
            //Console.WriteLine(val3);
            //hashMap.Remove(89);
            //hashMap.Put(95, 35);
            //int val4 = hashMap.Get(65);
            //Console.WriteLine(val4);
            //hashMap.Put(81, 61);
            //hashMap.Put(50, 33);
            //hashMap.Put(59, 5);
            //int val5 = hashMap.Get(75);
            //Console.WriteLine(val5);
            //hashMap.Put(80, 17);
            //hashMap.Put(35, 94);
            //hashMap.Put(80, 19);
            //hashMap.Put(13, 17);
            //hashMap.Put(70, 28);
            //hashMap.Put(28, 36);
            //hashMap.Put(99, 37);
            //int val6 = hashMap.Get(51);
            //Console.WriteLine(val6);
            //hashMap.Put(95, 30);
            //int val7 = hashMap.Get(37);
            //Console.WriteLine(val7);
            //hashMap.Put(51, 95);
            //hashMap.Put(65, 81);
            //int val8 = hashMap.Get(61);
            //Console.WriteLine(val8);
            //hashMap.Remove(50);
            //hashMap.Remove(33);
            //hashMap.Put(17, 13);
            //hashMap.Put(89, 90);
            //hashMap.Put(95, 41);
            //hashMap.Put(30, 50);
            //hashMap.Put(37, 29);
            //int val9 = hashMap.Get(65);
            //Console.WriteLine(val9);
            //int val10 = hashMap.Get(81);
            //Console.WriteLine(val10);
            //int val11 = hashMap.Get(50);
            //Console.WriteLine(val11);
            //int val12 = hashMap.Get(29);
            //Console.WriteLine(val12);
            //hashMap.Put(95, 54);
            //hashMap.Put(30, 6);
            //int val13 = hashMap.Get(54);
            //Console.WriteLine(val13);
            //hashMap.Put(15, 28);
            //int val14 = hashMap.Get(51);
            //Console.WriteLine(val14);
            //hashMap.Put(80, 69);
            //hashMap.Put(58, 92);
            //int val15 = hashMap.Get(13);
            //Console.WriteLine(val15);
            //int val16 = hashMap.Get(8);
            //Console.WriteLine(val16);
            //hashMap.Put(85, 31);
            //int val17 = hashMap.Get(60);
            //Console.WriteLine(val17);
            //hashMap.Put(9, 96);
            //hashMap.Put(96, 6);
            //hashMap.Put(35, 33);
            //hashMap.Put(54, 15);
            //hashMap.Put(13, 28);
            //hashMap.Put(8, 51);
            //int val18 = hashMap.Get(80);
            //Console.WriteLine(val18);
            //int val19 = hashMap.Get(36);
            //Console.WriteLine(val19);
            //hashMap.Remove(30);
            //hashMap.Put(85, 33);
            //int val20 = hashMap.Get(33);
            //Console.WriteLine(val20);
            //int val21 = hashMap.Get(42);
            //Console.WriteLine(val21);
            //hashMap.Remove(18);
            //hashMap.Put(68, 36);
            //hashMap.Put(50, 47);
            //hashMap.Put(32, 82);
            //int val22 = hashMap.Get(36);
            //Console.WriteLine(val22);
            //int val23 = hashMap.Get(30);
            //Console.WriteLine(val23);
            //int val24 = hashMap.Get(85);
            //Console.WriteLine(val24);
            //int val25 = hashMap.Get(33);
            //Console.WriteLine(val25);
            //hashMap.Put(87, 42);
            //hashMap.Put(18, 68);
            //hashMap.Put(68, 83);
            //hashMap.Put(50, 32);
            //int val26 = hashMap.Get(78);
            //Console.WriteLine(val26);
            //hashMap.Put(48, 90);
            //int val27 = hashMap.Get(97);
            //Console.WriteLine(val27);
            //int val28 = hashMap.Get(95);
            //Console.WriteLine(val28);
            //hashMap.Put(13, 8);
            //hashMap.Put(15, 15);
            //int val29 = hashMap.Get(5);
            //Console.WriteLine(val29);
            //int val30 = hashMap.Get(42);
            //Console.WriteLine(val30);
            //int val31 = hashMap.Get(20);
            //Console.WriteLine(val31);
            //int val32 = hashMap.Get(65);
            //Console.WriteLine(val32);
            //hashMap.Put(57, 57);
            //hashMap.Put(9, 2);
            //hashMap.Put(41, 6);
            //int val33 = hashMap.Get(33);
            //Console.WriteLine(val33);
            //hashMap.Put(16, 16);
            //hashMap.Put(44, 95);
            //hashMap.Put(95, 30);
        }

    }
//    Input
//["MyHashMap", "put", "put", "get", "get", "put", "get", "remove", "get"]
//[[], [1, 1], [2, 2], [1], [3], [2, 1], [2], [2], [2]]

    public class MyHashMap
    {
        List<int> listKey;
        List<int> listVal;

        public MyHashMap()
        {
            listKey = new List<int>();
            listVal = new List<int>();
        }
        public void Put(int key, int value)
        {
            foreach (var item in listKey)
            {
                if (item == key)
                {
                    listVal[listKey.IndexOf(key)] = value;
                    return;
                }
            }

            listKey.Add(key);
            listVal.Add(value);
        }

        public int Get(int key)
        {
            foreach (var item in listKey)
            {
                if (item == key)
                {
                    return listVal[listKey.IndexOf(key)];
                }
            }

            return -1;
        }

        public void Remove(int key)
        {
            var rInx = listKey.IndexOf(key);
            if (rInx == -1) return;
            listVal.RemoveAt(rInx);
            listKey.RemoveAt(rInx);
        }
    }

    public class MyHashMap2
    {
        private int[] data;

        public MyHashMap2()
        {
            data = new int[1000001]; // 初始化一個足夠大的數組，這個數組的下標表示鍵，值表示對應的值
            Array.Fill(data, -1); // 將所有元素初始化為 -1，表示該位置沒有存儲鍵值對
        }

        public void Put(int key, int value)
        {
            data[key] = value; // 將鍵值對存儲在對應的位置
        }

        public int Get(int key)
        {
            return data[key]; // 返回指定位置的值，如果該位置是 -1，表示沒有對應的鍵值對，返回 -1
        }

        public void Remove(int key)
        {
            data[key] = -1; // 將指定位置的值設置為 -1，表示刪除該鍵值對
        }
    }



}
