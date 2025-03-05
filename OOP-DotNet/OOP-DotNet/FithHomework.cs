namespace OOP_DotNet
{
    using System;
    using System.Collections.Generic;

    class FifthHomework
    {
        static void Main()
        {
            // Step 1: Get the size of the list
            Console.Write("Please input the size of the list: ");
            int n = int.Parse(Console.ReadLine());

            // Initialize lists and variables
            List<int> numbers = new List<int>();
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();
            int sumEven = 0;
            int sumOdd = 0;

            // Step 2: Input numbers into the list
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please input a number for List[{i}]: ");
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);

                // Check if the number is even or odd
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                    sumEven += number;
                }
                else
                {
                    oddNumbers.Add(number);
                    sumOdd += number;
                }
            }

            // Step 3: Display the results
            Console.WriteLine("\nYour list contains the following items: " + string.Join(", ", numbers));
            Console.WriteLine("The list of even numbers is: " + string.Join(", ", evenNumbers));
            Console.WriteLine("The list of odd numbers is: " + string.Join(", ", oddNumbers));
            Console.WriteLine("\nThe sum of even numbers is: " + sumEven);
            Console.WriteLine("The sum of odd numbers is: " + sumOdd);
        }
    }
}
