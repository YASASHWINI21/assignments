using System;
using System.Threading;

public class ExThread
{

    // Non-Static method 
    public void Mythread()
    {
        for (int x = 0; x < 4; x++)
        {
            Console.WriteLine(x);
            Thread.Sleep(100);
        }
    }

    // Non-Static method 
    public void Mythread1()
    {
        Console.WriteLine("2nd thread is Working..");
    }
}

// Driver Class 
public class ThreadExample
{
    // Main method 
    public static void Main()
    {
        // Creating instance for 
        // mythread() method 
        ExThread obj = new ExThread();

        // Creating and initializing threads 
        Thread thr1 = new Thread(new ThreadStart(obj.Mythread));
        Thread thr2 = new Thread(new ThreadStart(obj.Mythread1));
        thr1.Start();

        // Join thread 
        thr1.Join();
        thr2.Start();

    }
}
