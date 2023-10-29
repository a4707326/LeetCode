using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    internal class LC232_Implement_Queue_using_Stacks
    {
        public static void Start()
        {
            Console.WriteLine("LC977Squares_of_a_Sorted_Array");

            //int[] nums = { -4, -1, 0, 3, 10 };

            //var ans = SortedSquares(nums);


            //foreach (int i in ans) 
            //{
            //    Console.WriteLine(i.ToString());
            //}

            MyQueue myQueue = new MyQueue();
            myQueue.Push(1);
            myQueue.Push(2);
            myQueue.Peek();
            Console.WriteLine(myQueue.Pop());
            Console.WriteLine(myQueue.Pop());
            myQueue.Show();
            Console.WriteLine(myQueue.Empty());

            //Console.WriteLine(myQueue.Peek());
        }


    }



    //Your MyQueue object will be instantiated and called as such:
    //MyQueue obj = new MyQueue();，
    //obj.Push(x);
    //int param_2 = obj.Pop();
    //int param_3 = obj.Peek();
    //bool param_4 = obj.Empty();



//    Input
//["MyQueue", "push", "push", "peek", "pop", "empty"]
//[[], [1], [2], [], [], []]
//Output
//[null, null, null, 1, 1, false]

//Explanation
//MyQueue myQueue = new MyQueue();
//    myQueue.push(1); // queue is: [1]
//myQueue.push(2); // queue is: [1, 2] (leftmost is front of the queue)
//myQueue.peek(); // return 1
//myQueue.pop(); // return 1, queue is [2]
//myQueue.empty(); // return false

    //

    public class MyQueue
    {

        Stack<int> stack;
        Stack<int> stack2;
        public MyQueue()
        {
            stack = new Stack<int>();
            stack2 = new Stack<int>();
        }

        public void Push(int x)
        {
            stack.Push(x);
        }

        public int Pop()
        {
            int reInt = Peek();
            stack2.Clear();
            foreach (int x in stack)
            {
                stack2.Push(x);
            }
            stack2.Pop();

            stack.Clear();
            foreach (int x in stack2)
            {
                stack.Push(x);
            }
            return reInt;
        }

        public int Peek()
        {
            int reInt = 0;
            foreach (var item in stack)
            {
                reInt = item;

            }
            return reInt;
        }

        public bool Empty()
        {
            return stack.Count == 0 ;
        }

        public void Show()
        {
            foreach (var item in stack) 
            {
                Console.WriteLine(item);
            }
        }
    }
}
