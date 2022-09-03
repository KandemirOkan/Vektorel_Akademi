using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Thread
            //    Thread thread1 = new Thread(OkanThread1);
            //    Thread thread2 = new Thread(OkanThread2);
            //    thread1.Start();
            //    thread2.Start();
            //    for (int i = 0; i < 20; i++)
            //    {
            //        Thread.Sleep(100);
            //        Console.WriteLine("Main Thread çalışıyor.");
            //    }
            //    thread1.Abort();

            //    Console.ReadLine();
            //}
            //static void OkanThread1()
            //{
            //    for (int i = 0; i < 20; i++)
            //    {
            //        Thread.Sleep(200);
            //        Console.WriteLine("Thread-1 çalışıyor.");
            //    }
            //}
            //static void OkanThread2()
            //{
            //    for (int i = 0; i < 20; i++)
            //    {
            //        Thread.Sleep(200);
            //        Console.WriteLine("Thread-2 çalışıyor.");
            //    } 
            #endregion
            //OkanTask();
            Task task1 = new Task(OkanTask1);
            task1.Start();
            Task task2 = new Task(OkanTask2);
            task2.Start();
            for (int i = 0; i < 20; i++)
            {
                //Thread.Sleep(200);
                Console.WriteLine("Main Thread çalışıyor..");
            }
            Console.ReadLine();
        }
        #region async Task
        //static async Task OkanTask()
        //{
        //    await Task.Run(() =>
        //    {
        //        for (int i = 0; i < 100; i++)
        //        {
        //            Thread.Sleep(200);
        //            Console.WriteLine("awaitli task çalışıyor.");
        //        }
        //    });
        //    for (int i = 0; i < 100; i++)
        //    {
        //        Thread.Sleep(200);
        //        Console.WriteLine("ikincil task çalışıyor.");
        //    }
        //} 
        #endregion
        static void OkanTask1()
        {
            for (int i = 0; i < 20; i++)
            {
                //Thread.Sleep(200);
                Console.WriteLine("Okan senkron Task-1 çalıştı...");
            }
        }
        static void OkanTask2()
        {
            for (int i = 0; i < 20; i++)
            {
                //Thread.Sleep(200);
                Console.WriteLine("Okan senkron Task-2 çalıştı...");
            }
        }
    }
}
