using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace testsnippets1
{
    internal class Linq
    {
        public static void LinqExample(List<int> numbers)
        {
            
            // Using LINQ to filter even numbers
            var evenNumbers = numbers.Where(n => n % 2 == 0).OrderBy(n => n);
            // Using LINQ to filter odd numbers
            var oddNumbers = numbers.Where(n => n % 2 != 0).OrderBy(n => n);
            Console.WriteLine("Even Numbers:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Odd Numbers:");
            foreach (var num in oddNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
