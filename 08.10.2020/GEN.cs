using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genprec
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
            Func<int, int, int> obj1 = (x, y) => (x * y);

            double result1 = obj1.Invoke(10, 20);//New variable to store the value -return type
            Console.WriteLine(result1);


            Func<string, string> p = name1 => "Hello" + name1;

            string name = p.Invoke("Harshu");
            Console.WriteLine(name);

            Action<int, float, double> obj2 = (x, y, z) => Console.WriteLine(x + y + z);

            obj2.Invoke(10, 3.142f, 123456.7809738);//Non return type

            Action<string> w = (wish) => Console.WriteLine(wish + " A " + "Happy Birthday!!!!!!");

            w.Invoke("wish you ");


            Predicate<string> obj3 = (name1) =>
            {
                //check the string whose length is greater than 4 should print true else false;
                if (name.Length > 4)
                    return true;
                return false;
            };


            bool check = obj3.Invoke("Yashu");
            Console.WriteLine(check);

            Predicate<string> o = (name1) =>
            {
                //check the string whose length is greater than 4 should print true else false;
                if (name1.Length < 10)
                    return true;
                return false;
            };//New variable to store the value -return type

            bool ch = o.Invoke(" CHEEKATI ");
            Console.WriteLine(ch);


            Console.ReadLine();


        }
    }
}
