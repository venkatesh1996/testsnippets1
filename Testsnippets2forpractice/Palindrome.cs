using System;
using System.Collections.Generic;
using System.Text;

namespace Testsnippets2forpractice
{
    public class Palindrome
    {
        public static void CheckPalindrome(string input)
        {
            Console.WriteLine($"Checking if '{input}' is a palindrome...");
            // Remove whitespace and convert to lowercase
            string processedInput = input.Replace(" ", "").ToLower();
            // Reverse the string
            char[] charArray = processedInput.ToCharArray();
            Array.Reverse(charArray);
            string reversedInput = new string(charArray);
            // Check if the original processed input is equal to the reversed input
            if (processedInput == reversedInput)
            {
                Console.WriteLine($"'{input}' is a palindrome.");
            }
            else
            {
                Console.WriteLine($"'{input}' is not a palindrome.");
            }
        }
        public static void checkPalindromeWithLinq(string input)
        {
            Console.WriteLine($"Checking if '{input}' is a palindrome using linq...");
            // Remove whitespace and convert to lowercase
            string processedInput = input.Replace(" ", "").ToLower();
            // Use LINQ to reverse the string
            string reversedInput = new string(processedInput.Reverse().ToArray());
            // Check if the original processed input is equal to the reversed input
            if (processedInput == reversedInput)
            {
                Console.WriteLine($"'{input}' is a palindrome (checked with LINQ).");
            }
            else
            {
                Console.WriteLine($"'{input}' is not a palindrome (checked with LINQ).");
            }
        }
        public static void checkPalindromeForNumbers(int number)
        {
            Console.WriteLine($"Checking if {number} is a palindrome...");
            // Convert the number to string
            string input = number.ToString();
            // Reverse the string representation of the number
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversedInput = new string(charArray);
            // Check if the original number is equal to the reversed number
            if (input == reversedInput)
            {
                Console.WriteLine($"{number} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{number} is not a palindrome.");
            }
        }
    }
}
