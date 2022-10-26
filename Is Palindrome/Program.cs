using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_Palindrome
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * Given an integer x, return true if x is palindrome integer
             * An integer is a palindrome when it reads the same backward as forward.
             * For example, 121 is a palindrome while 123 is not.
             
             */
            Console.WriteLine("Please enter the number you want" +
                              " to know if it is a palindrome number");
            int number;
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(IsPalindrome(number));

            Console.ReadLine();
        }
        
        public static bool IsPalindrome(int aNumber)
        {
            string numbers = aNumber.ToString();
            char[] chars = numbers.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                char c = chars[i];
                Array.Reverse(chars);

                if (c == chars[i])
                {
                    Array.Reverse(chars);
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}

