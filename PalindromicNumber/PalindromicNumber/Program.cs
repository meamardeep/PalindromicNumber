using System;

namespace PalindromicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            long number;
            Console.WriteLine("Enter a nnumber to check whether its palindome or not");
            number = long.Parse(Console.ReadLine());
            long reverseNumber = 0;

            while (number != 0)
            {
                reverseNumber = (reverseNumber * 10) + (number % 10);
                number = number / 10;
            }

            if (reverseNumber == number)
            {
                Console.WriteLine("Given Number is palindrome");
            }
            else
                Console.WriteLine("Entered number is not palindrome");

            Console.ReadLine();
        }
    }
}
