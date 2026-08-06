using System;
using System.Threading;
class Threading
{
    public static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Worker Thread: " + i);
            Thread.Sleep(500); // Simulate work
        }
    }
   
}