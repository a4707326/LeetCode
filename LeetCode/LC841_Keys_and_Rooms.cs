using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC841_Keys_and_Rooms
    {
        public static void Start()
        {
            Console.WriteLine("LC841_Keys_and_Rooms");



            List<IList<int>> rooms = new List<IList<int>> {
                new List<int> {1},
                new List<int> {2},
                new List<int> {3},
                new List<int> {} // 空房間可以不用初始化
            };

            var ans = CanVisitAllRooms(rooms);


            Console.WriteLine(ans);

        }

        //Input: rooms = [[1],[2],[3],[]]
        //Output: true
        //時間複雜度是O(N + K)，其中N是房間的數量，K是鑰匙的總數，空間複雜度是O(N)
        public static bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            List<int> keyList = new List<int>();
            bool[] openRooms = new bool[rooms.Count];

            for (int i = 0; i < rooms[0].Count; i++)
            {
                keyList.Add(rooms[0][i]);
            }
            openRooms[0] = true;

            while (keyList.Count > 0)
            {
                if (openRooms[keyList[0]] == false)
                {
                    openRooms[keyList[0]] = true;

                    for (int i = 0; i < rooms[keyList[0]].Count; i++)
                    {
                        keyList.Add(rooms[keyList[0]][i]);
                    }
                }
                keyList.RemoveAt(0);

            }

            bool isAllOpen = true;
            foreach (bool room in openRooms)
            {
                if (!room)
                {
                    isAllOpen = false;
                    break;
                }
            }


            return isAllOpen;
        }

    }



}
