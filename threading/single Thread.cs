using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace singlethreadexample
{

    class mythreads
    {
        public double sumThread1(int num)
        {
            int rem;
            double sum = 0;
            while (num != 0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }

            return sum;
        }

        public string cancatthread2(string s1, string s2)
        {
            return s1 + s2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");
            mythreads obj = new mythreads();
            double result = 0;

            Thread T1 = new Thread(() => { result = obj.sumThread1(78675); });
            T1.Start();
            T1.Join();
            Console.WriteLine(result);
            Console.WriteLine("thread 1 execution completed");

            string res = null;
            Thread T2 = new Thread(() => { res = obj.cancatthread2("bunny", "yash"); });

            T2.Start();
            T2.Join();
            Console.WriteLine(res);
            Console.WriteLine("thread 2 execution completed");

            string res1 = null;
            Thread T3 = new Thread(() => { res = obj.cancatthread2("honney", "bunny"); });

            Console.WriteLine();
            Console.WriteLine("Main Thread completed");
            Console.ReadKey();


        }
    }
}