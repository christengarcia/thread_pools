/*
 * C# Program to Create Thread Pools
 */
using System;
using System.Threading;

namespace thread_pools
{
    class ThreadPool
    {
        public void Task1(object obj)
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Task 1 is being executed");
            }
        }

        public void Task2(object obj)
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Task 2 is being executed");
            }
        }

        static void Main()
        {
            ThreadPool tpd = new ThreadPool();
            for (int i = 0; i < 2; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(tpd.Task1));
                ThreadPool.QueueUserWorkItem(new WaitCallback(tpd.Task2));
            }

            Console.Read();
        }
    }
}
