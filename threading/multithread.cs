using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace multithreadingassign
{
    class mythreads
    {
        public int sumThread1(int num1, int num2)
        {

            return num1 + num2;
        }

        public int strlenthred2(string str)
        {
            Thread.Sleep(2000);
            return str.Length;
        }

        public string cancatthread2(string s1, string s2)
        {
            return s1 + s2;
        }
        public bool isodd(int num)
        {
            Thread.Sleep(3000);
            if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;

            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            mythreads obj = new mythreads();
            int sum = 0;
            int length = 0;
            string s = null;
            bool x = true;
            Thread T1 = new Thread(() => { sum = obj.sumThread1(23, 67); });
            Thread T2 = new Thread(() => { length = obj.strlenthred2("shannu"); });
            Thread T3 = new Thread(() => { s = obj.cancatthread2("yashu", "sony"); });
            Thread T4 = new Thread(() => { x = obj.isodd(45678); });
            T1.Start();
            T2.Start();
            T3.Start();
            T4.Start();
            T1.Join();
            T2.Join();
            T3.Join();
            T4.Join();
            Console.WriteLine("the sum of two numbers is {0}", sum);
            Console.WriteLine("the length of the string is {0}", length);
            Console.WriteLine("the cancatenated string is {0} ", s);
            Console.WriteLine("the given number is odd(true/false) {0}", x);
            Console.ReadKey();




        }
    }
}