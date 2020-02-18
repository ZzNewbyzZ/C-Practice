using System;

namespace NumberUtils
{
    class NumberUtilities
    {
        public static int AddInt()
        {
            Console.WriteLine("Add 2 integers");
            Console.WriteLine("==============");

            // Ask user for first integer
            Console.WriteLine("Enter the first integer:");
            string firstNum = Console.ReadLine();

            Console.WriteLine(); // Blank for spacing

            // Ask user for second integer
            Console.WriteLine("Enter the second integer:");
            string secondNum = Console.ReadLine();

            Console.WriteLine(); // Blank for spacing

            // Convert from string to int
            int Num1 = Convert.ToInt32(firstNum);
            int Num2 = Convert.ToInt32(secondNum);

            // Return the sum
            return Num1 + Num2;
        }

        public static int SubtractInt()
        {
            Console.WriteLine("Subtract 2 integers");
            Console.WriteLine("===================");

            // Ask user for first integer
            Console.WriteLine("Enter the first integer:");
            string firstNum = Console.ReadLine();

            Console.WriteLine(); // Blank for spacing

            // Ask user for second integer
            Console.WriteLine("Enter the second integer:");
            string secondNum = Console.ReadLine();

            Console.WriteLine(); // Blank for spacing

            // Convert from string to int
            // Convert from string to int
            int Num1 = Convert.ToInt32(firstNum);
            int Num2 = Convert.ToInt32(secondNum);

            // Return the sum
            return Num1 - Num2;
        }

        public static void Main()
        {
            Console.WriteLine("Your sum is " + AddInt());

            Console.WriteLine();

            Console.WriteLine("Your difference is " + SubtractInt());
        }
    }
}
