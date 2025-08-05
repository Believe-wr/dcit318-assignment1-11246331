using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Triangle Type Identifier ===");

        // Prompt the user to enter the 3 sides
        Console.Write("Enter the length of side A: ");
        string inputA = Console.ReadLine();

        Console.Write("Enter the length of side B: ");
        string inputB = Console.ReadLine();

        Console.Write("Enter the length of side C: ");
        string inputC = Console.ReadLine();

        // Convert input to numbers and validate
        if (double.TryParse(inputA, out double a) &&
            double.TryParse(inputB, out double b) &&
            double.TryParse(inputC, out double c) &&
            a > 0 && b > 0 && c > 0)
        {
            // Check if the sides form a valid triangle
            if (a + b > c && a + c > b && b + c > a)
            {
                // Determine the triangle type
                if (a == b && b == c)
                {
                    Console.WriteLine("This is an Equilateral triangle.");
                }
                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("This is an Isosceles triangle.");
                }
                else
                {
                    Console.WriteLine("This is a Scalene triangle.");
                }
            }
            else
            {
                Console.WriteLine("The entered sides do not form a valid triangle.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter positive numbers only.");
        }
    }
}
