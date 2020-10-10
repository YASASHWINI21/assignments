using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace semaphores
{
    class program
    {
        public static Semaphore semaphore = new Semaphore(4, 5);//Initializing semaphore

        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Thread threadObject = new Thread(Sync)
                {
                    Name = "Thread " + i
                };
                threadObject.Start(i);
            }
            Console.ReadKey();
        }
        static void Sync(object id)
        {
            Console.WriteLine(Thread.CurrentThread.Name + " Semphore Critical Section for processing");
            //try
            //{
            //Blocks the current thread until the current WaitHandle receives a signal.   
            semaphore.WaitOne();
            Console.WriteLine("Success: " + Thread.CurrentThread.Name + " is Doing its work");
            Thread.Sleep(10000);
            Console.WriteLine(Thread.CurrentThread.Name + "Exit.");
            //}
            //finally
            //{
            //Release() method to release semaphore  
            semaphore.Release();
            Console.ReadKey();
            //}
        }
    }
}