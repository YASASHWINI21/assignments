using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace six.delegat
{

    public delegate int MultiplynumsDelegate(int x, int y);
    public delegate string QuickDelegate(string str);
    public delegate void Addnums2Delegate(int x, float y, double z);
    public delegate void GreetingsDelegate(string str);
    public delegate bool CheckLengthDelegate(String str);
    class Sixdelegate
    {


        //Method with return value
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
        public static bool Value(string name1)
        {
            //check the string whose length is greater than 4 should print true else false;
            if (name1.Length < 10)
                return true;
            return false;
        }
        static void Main(string[] args)
        {



            MultiplynumsDelegate obj = new MultiplynumsDelegate(Multiplynums);
            double result1 = obj.Invoke(10, 20);//New variable to store the value -return type
            Console.WriteLine(result1);
            QuickDelegate p = new QuickDelegate(Quick);
            string name = p.Invoke("Mumma");
            Console.WriteLine(name);

            Addnums2Delegate obj2 = new Addnums2Delegate(Addnums2);
            obj2.Invoke(10, 3.142f, 123456.7809738);//Non return type

            GreetingsDelegate w = new GreetingsDelegate(Wishes);
            w.Invoke("wish you ");


            CheckLengthDelegate obj3 = new CheckLengthDelegate(CheckLength);//New variable to store the value -return type

            bool check = obj3.Invoke("Haritha");
            Console.WriteLine(check);

            CheckLengthDelegate o = new CheckLengthDelegate(Value);//New variable to store the value -return type

            bool ch = o.Invoke("Maredapaaly");
            Console.WriteLine(ch);


            Console.ReadLine();



        }
    }
}
