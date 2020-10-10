using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace nonstaticthread
{
    class Program
    {
        public string Thread1(string name)
        {
            return "thread1 started";
        }
        public int Thread2(int i)
        {
            for (i = 0; i < 15; i++)
            {
                if (i == 10)
                {
                    Console.WriteLine("the thread2 is sleeping");

                    Thread.Sleep(10000);
                }
                Console.WriteLine("the thread is at the position :" + i);
            }
            return i;
        }
        public string Thread3(string str)
        {
            if (str.Length > 5)
            {
                Console.WriteLine("the thread 2 was sleeping for 5 seconds");

                Thread.Sleep(5000);
            }
            return "thread3 started";
        }

        static void Main(string[] args)
        {

            Program n = new Program();
            string s = n.Thread1("non static");
            Console.WriteLine(s);
            int j = n.Thread2(5);
            Console.WriteLine(j);
            string a = n.Thread3("Thread programming");
            Console.WriteLine(a);

            Console.WriteLine("Main thread executed all the threads");
            Console.ReadLine();


        }
    }
}