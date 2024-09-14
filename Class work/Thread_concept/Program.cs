using System;
using System.Threading;
namespace Thread_concept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread new_thread=Thread.CurrentThread;
            Console.WriteLine(Thread.CurrentThread.Name);
        }
        


    }
}
