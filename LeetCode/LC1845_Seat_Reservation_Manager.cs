using System;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC1845_Seat_Reservation_Manager
    {
        public static void Start()
        {
            Console.WriteLine("LC1845_Seat_Reservation_Manager");

            SeatManager2 seatManager = new SeatManager2(5); // Initializes a SeatManager with 5 seats.
            seatManager.Reserve();    // All seats are available, so return the lowest numbered seat, which is 1.
            seatManager.Reserve();    // The available seats are [2,3,4,5], so return the lowest of them, which is 2.
            seatManager.Unreserve(2); // Unreserve seat 2, so now the available seats are [2,3,4,5].
            seatManager.Reserve();    // The available seats are [2,3,4,5], so return the lowest of them, which is 2.
            seatManager.Reserve();    // The available seats are [3,4,5], so return the lowest of them, which is 3.
            seatManager.Reserve();    // The available seats are [4,5], so return the lowest of them, which is 4.
            seatManager.Reserve();    // The only available seat is seat 5, so return 5.
            seatManager.Unreserve(5); // Unreserve seat 5, so now the available seats are [5].

        }
    }

    //Input
    //["SeatManager", "reserve", "reserve", "unreserve", "reserve", "reserve", "reserve", "reserve", "unreserve"]
    //[[5], [], [], [2], [], [], [], [], [5]]
    //Output
    //[null, 1, 2, null, 2, 3, 4, 5, null]

    public class SeatManager
    {
        int[] seats;
        int curIndex = 1;
        public SeatManager(int n)//O(n)
        {
            seats = new int[n+1];
            seats[0] = 1;
        }

        public int Reserve()//O(n)
        {
            curIndex = Array.IndexOf(seats, 0);
            seats[curIndex] = 1;
            Console.WriteLine(curIndex);
            return curIndex;
        }

        public void Unreserve(int seatNumber)//O(1)
        {
            seats[seatNumber] = 0;
        }
    }
    public class SeatManager2
    {
        PriorityQueue<int, int> pq;
        public SeatManager2(int n)//O(n)
        {
            pq = new();
            for (int i = 1; i < n + 1; i++)
            {
                pq.Enqueue(i, i);
            }
        }
        public int Reserve()//O(log n)
        {
            return pq.Dequeue();
        }
        public void Unreserve(int seatNumber)//O(log n)
        {
            pq.Enqueue(seatNumber, seatNumber);
        }
    }
}
