using System;

public class Demo
{
    public static void Main(string[] args)
    {
        string[] strArr = { "One", "Two", "Three", "Four" };
        Console.WriteLine("String Array...");
        foreach (string s in strArr)
        {
            Console.WriteLine(s);
        }
        string str = string.Join("/", strArr);
        Console.WriteLine("Result (after joining) = " + str);
    }
}