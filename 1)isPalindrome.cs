using System;

namespace IsPalindromeFun1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Let's Check whether text is palindrome or not  ");
            string str1;
            bool isPal;
            Console.WriteLine(" Input text: ");
            str1 = Console.ReadLine();
            isPal = isPalindrome(str1);

            if (isPal == true)
            {
                Console.WriteLine("The text is a palindrome! ");
            }
            else
            {
                Console.WriteLine("The text is not a palindrome! ");
            }
        }

        static bool isPalindrome(String text)
        {
            if (text.Length <= 1)
                return true;
            else
            {
                if (text[0] != text[text.Length - 1])
                    return false;
                else
                    return isPalindrome(text.Substring(1, text.Length - 2));
            }
        }
    }
}
