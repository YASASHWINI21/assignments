using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lockex
{
    class Program
    {
        static object x = new object();
        static void AnotherMethod()
        {
            lock (x) { Console.WriteLine("another method "); }
        }
        static void Main(string[] args)
        {
            lock (x)
            {
                AnotherMethod();
                //we still have the lock
            }
            Console.ReadLine();
        }
    }
}
