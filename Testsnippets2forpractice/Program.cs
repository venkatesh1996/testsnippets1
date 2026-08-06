using static Testsnippets2forpractice.Palindrome;

namespace Testsnippets2forpractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Testsnippets2forpractice Program!");
            CheckPalindrome("A man a plan a canal Panama");
            checkPalindromeWithLinq("Was it a car or a cat I saw");
            checkPalindromeForNumbers(12321);
            Console.WriteLine("End of the program");
        }
    }
}
