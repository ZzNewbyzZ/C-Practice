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

        public static int AddInt(int num1, int num2)
        {
            return num1 + num2;
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

        public static int SubtractInt(int num1, int num2)
        {
            return num1 - num2;
        }


        public static int MaxInt(int[] array)
        {
            int max = -2147483646;

            foreach (int i in array)
            {
                if(max < i)
                {
                    max = i;
                }
            }

            return max;
        }

        public static int MinInt(int[] array)
        {
            int min = 2147483647;

            foreach (int i in array)
            {
                if(min > i)
                {
                    min = i;
                }
            }

            return min;
        }

        public static void Main()
        {
            Console.WriteLine("Your sum is " + AddInt());

            Console.WriteLine();

            Console.WriteLine("Your difference is " + SubtractInt());

            Console.WriteLine();

            Console.WriteLine("156 + 210 = " + AddInt(156, 210));

            Console.WriteLine();

            Console.WriteLine("210 - 200 = " + SubtractInt(210, 200));

            Console.WriteLine();

            int[] array = { 126, 200, 123484531, - 16, 345674 };

            Console.Write("The max in ");

            foreach (int i in array)
            {
                Console.Write(i + ",");
            }

            Console.Write(" is " + MaxInt(array));

            Console.WriteLine();

            Console.Write("The min in ");

            foreach (int i in array)
            {
                Console.Write(i + ",");
            }

            Console.Write(" is " + MinInt(array));

            Console.WriteLine();
        }
    }
}
