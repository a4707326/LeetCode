using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class WC422_Q2_Find_Minimum_Time_to_Reach_Last_Room_I
    {
        public static void Start()
        {
            Console.WriteLine("WC422_Q2_Find_Minimum_Time_to_Reach_Last_Room_I");



            int[][] m = new int[][]
            {
                new int[] { 0,1 },
                new int[] { 1,2 },
            };



            var ans = MinTimeToReach(m);
            
 


            Console.WriteLine(ans);

        }

        //Input: moveTime = [[0,4],[4,4]]
        //Output: 6
        static int MinTimeToReach(int[][] moveTime)
        {
            int n = moveTime.Length;
            int m = moveTime[0].Length;

            // 初始化 minTime ，先定義一個最大數
            int[,] minTime = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    minTime[i, j] = int.MaxValue;
                }
            }

            // 定義四個可能的移動方向
            int[] dx = { 0, 1, 0, -1 };
            int[] dy = { 1, 0, -1, 0 };

            // 優先隊列，用來根據最小時間處理房間
            PriorityQueue<(int time, int x, int y), int> pq = new PriorityQueue<(int, int, int), int>();
            pq.Enqueue((0, 0, 0), 0);
            minTime[0, 0] = 0;

            while (pq.Count > 0)
            {
                var (time, x, y) = pq.Dequeue();

                // 如果已經到達最後一個房間，返回所需的時間
                if (x == n - 1 && y == m - 1)
                {
                    return time;
                }

                // 如果此時間不是已記錄的最小時間，則跳過
                if (time > minTime[x, y]) continue;

                // 探索四個相鄰的房間
                for (int i = 0; i < 4; i++)
                {
                    int nx = x + dx[i];
                    int ny = y + dy[i];

                    // 檢查邊界條件
                    if (nx >= 0 && nx < n && ny >= 0 && ny < m)
                    {
                        int nextTime = time + 1 ;

                        // 檢查是否需要等待以符合 moveTime 條件
                        if (nextTime < moveTime[nx][ny]+1)
                        {
                            nextTime = moveTime[nx][ny] + 1;
                            //nextTime = moveTime[nx][ny] + ((moveTime[nx][ny] % 2 == nextTime % 2) ? 0 : 1);
                        }

                        // 如果找到更短的時間到達 (nx, ny)，則更新並加入隊列
                        if (nextTime < minTime[nx, ny])
                        {
                            minTime[nx, ny] = nextTime ;
                            pq.Enqueue((nextTime, nx, ny), nextTime);
                        }
                    }
    
                }
                //var ss = pq.Peek();
                //time += minTime[ss.x, ss.y];

            }

            // 如果無法到達最後一個房間，返回 -1
            return -1;
        }


        static int MinTimeToReachLastRoom(int[][] moveTime)
        {
            int n = moveTime.Length;
            int m = moveTime[0].Length;
            int[][] directions = new int[][]
            {
            new int[] { 0, 1 }, // right
            new int[] { 1, 0 }, // down
            new int[] { 0, -1 }, // left
            new int[] { -1, 0 }  // up
            };

            PriorityQueue<(int, int, int), int> pq = new PriorityQueue<(int, int, int), int>();
            pq.Enqueue((0, 0, 0), 0); // (row, col, current_time)

            int[,] visited = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    visited[i, j] = int.MaxValue;
                }
            }
            visited[0, 0] = 0;

            while (pq.Count > 0)
            {
                var (x, y, currentTime) = pq.Dequeue();

                // If we reached the bottom-right corner, return the current time
                if (x == n - 1 && y == m - 1)
                {
                    return currentTime;
                }

                // Explore all possible directions
                foreach (var direction in directions)
                {
                    int nx = x + direction[0];
                    int ny = y + direction[1];

                    if (nx >= 0 && nx < n && ny >= 0 && ny < m)
                    {
                        // Calculate the earliest possible time to move to the next room
                        int waitTime = Math.Max(0, moveTime[nx][ny] - (currentTime + 1));
                        int nextTime = currentTime + 1 + waitTime;
                        if (nextTime < visited[nx, ny])
                        {
                            visited[nx, ny] = nextTime;
                            pq.Enqueue((nx, ny, nextTime), nextTime);
                        }
                    }
                }
            }

            return -1; // In case there's no valid path
        }

    }



}
