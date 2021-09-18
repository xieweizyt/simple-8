using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace simple_8
{
    public static class SimpleAsync
    {
        public static void Show()
        {
            Console.WriteLine($"statr show thread id = {Thread.CurrentThread.ManagedThreadId.ToString("00")}");
            ShowTest1();
            Console.WriteLine($"end show thread id = {Thread.CurrentThread.ManagedThreadId.ToString("00")}");
        }

        private static async Task ShowTest1()
        {
            Console.WriteLine($"statr ShowTest1 thread id = {Thread.CurrentThread.ManagedThreadId.ToString("00")}");

            await Task.Run(() =>
            {
                Console.WriteLine($"statr Task thread id = {Thread.CurrentThread.ManagedThreadId.ToString("00")}");
                Thread.Sleep(1000);
                Console.WriteLine($"end Task thread id = {Thread.CurrentThread.ManagedThreadId.ToString("00")}");
            });

            Console.WriteLine($"end ShowTest1 thread id = {Thread.CurrentThread.ManagedThreadId.ToString("00")}");
        }
    }
}
