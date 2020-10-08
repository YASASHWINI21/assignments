using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymous
{
    public delegate int MultiplynumsDelegate(int x, int y);
    public delegate string QuickDelegate(string str);
    public delegate void Addnums2Delegate(int x, float y, double z);
    public delegate void GreetingsDelegate(string str);
    public delegate bool CheckLengthDelegate(String str);
    class Program
    {
        /*//Method with return value
        public static int Multiplynums(int x, int y)
        {
            return (x * y);
        }
        public static string Quick(string name)
        {
            return "Hello" + name;
        }
        //method without return value
        public static void Addnums2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }
        //method without return value
        public static void Wishes(string wish)
        {
            Console.WriteLine(wish + " A " + "Happy Birthday!!!!!!");
        }
        public static bool CheckLength(string name)
        {
            //check the string whose length is greater than 4 should print true else false;
            if (name.Length > 4)
                return true;
            return false;
        }
        public static bool value(string name1)
        {
            //check the string whose length is greater than 4 should print true else false;
            if (name1.Length < 10)
                return true;
            return false;
        }*/
        static void Main(string[] args)
        {
            int obj(int x, int y)
            {
                return (x * y);
            }
            double result1 = obj(10, 20);//New variable to store the value -return type
            Console.WriteLine(result1);


            string p(string name1)
            {
                return "Hello" + name1;
            }
            string name = p("SHANNU");
            Console.WriteLine(name);

            void obj2(int x, float y, double z)
            {
                Console.WriteLine(x + y + z);
            }
            obj2(10, 3.142f, 123456.7809738);//Non return type

            void w(string wish)
            {
                Console.WriteLine(wish + " A " + "Happy Birthday!!!!!!");
            }
            w("wish you ");


            bool obj3(string name1)
            {
                //check the string whose length is greater than 4 should print true else false;
                if (name.Length > 4)
                    return true;
                return false;
            }


            bool check = obj3("Shannu");
            Console.WriteLine(check);

            bool o(string name1)
            {
                //check the string whose length is greater than 4 should print true else false;
                if (name1.Length < 10)
                    return true;
                return false;
            }//New variable to store the value -return type

            bool ch = o("Yashu");
            Console.WriteLine(ch);


            Console.ReadLine();



        }
    }
}