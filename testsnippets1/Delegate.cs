using System;
using System.Collections.Generic;
using System.Text;

namespace testsnippets1
{
    internal class MyDelegates
    {
        public delegate void PrintDelegate<T>(T message);
        public static void PrintSentence<T>(T message)
        {
            Console.WriteLine("The value is:"+message);
        }
    }
}
