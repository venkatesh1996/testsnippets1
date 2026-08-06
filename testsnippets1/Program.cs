using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using testsnippets1.Dbcontext;
using testsnippets1.Models;

namespace testsnippets1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5, 4, 3, 2, 1 };
            MyDelegates.PrintDelegate<string> del = MyDelegates.PrintSentence;
            del("Hi Everyone!");
            MyDelegates.PrintDelegate<int> del2 = MyDelegates.PrintSentence;
            del2(12345);
            Linq.LinqExample(numbers);
            Sorting.BubbleSort(numbers);
            Sorting.SelectionSort(numbers);
            Sorting.InsertionSort(numbers);
            Sorting.MergeSortCall(numbers);

            Thread t1 = new Thread(Threading.PrintNumbers);
            t1.Start(); // Start worker thread
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Main Thread: " + i);
                Thread.Sleep(500);
            }

            //using (var context = new SentenceDbContext())
            //{
            //    var sentence = new SentenceHolder { Id = 1, Sentence = "Hello, World!" };
            //    context.Sentences.Add(sentence);
            //    context.SaveChanges();
            //    var sentences = context.Sentences.ToList();
            //    foreach (var s in sentences)
            //    {
            //        Console.WriteLine(s.Sentence);
            //    }
            //    context.Sentences.Remove(sentence);
            //    context.SaveChanges();
            //    foreach (var s in context.Sentences.ToList())
            //    {
            //        Console.WriteLine(s.Sentence);
            //    }
            //}
            using (var context = new SentenceDbContext())
            {
                // CREATE
                var sentence = new SentenceHolder { Sentence = "Hello, SQL Server!" };
                context.Sentences.Add(sentence);
                context.SaveChanges();

                // READ
                var sentences = context.Sentences.ToList();
                Console.WriteLine("Sentences in DB:");
                foreach (var s in sentences)
                {
                    Console.WriteLine($"{s.Id} - {s.Sentence}");
                }

                // UPDATE
                var sentenceToUpdate = context.Sentences.First();
                sentenceToUpdate.Sentence = "Updated sentence!";
                context.SaveChanges();

                Console.WriteLine("\nAfter Update:");
                foreach (var s in context.Sentences)
                {
                    Console.WriteLine($"{s.Id} - {s.Sentence}");
                }

                // DELETE
                var sentenceToDelete = context.Sentences.First();
                context.Sentences.Remove(sentenceToDelete);
                context.SaveChanges();

                Console.WriteLine("\nAfter Delete:");
                foreach (var s in context.Sentences)
                {
                    Console.WriteLine($"{s.Id} - {s.Sentence}");
                }
            }
        }
    }
}
