using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    public delegate int MultiplynumsDelegate(int x, int y);
    public delegate string QuickDelegate(string str);
    public delegate void Addnums2Delegate(int x, float y, double z);
    public delegate void GreetingsDelegate(string str);
    public delegate bool CheckLengthDelegate(String str);
    class Program
    {
        static void Main(string[] args)
        {
            int Obj(int x, int y)
            {
                return (x * y);
            }
            double result1 = Obj(10, 20);//New variable to store the value -return type
            Console.WriteLine(result1);


            string p(string name1)
            {
                return "Hello" + name1;
            }
            string name = p("harshu");
            Console.WriteLine(name);

            void obj2(int x, float y, double z)
            {
                Console.WriteLine(x + y + z);
            }
            obj2(10, 3.142f, 123456.7809738);//Non return type

            void w(string wish)
            {
                Console.WriteLine(wish + " " + "Happy Birthday!!!!!!");
            }
            w("wish you ");
        }
    }
}
    