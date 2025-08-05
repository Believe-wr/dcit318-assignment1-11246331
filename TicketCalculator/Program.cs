using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Ticket Price Calculator ===");

        Console.Write("Enter your age: ");
        string input = Console.ReadLine();

        // Validate that the input is a number and not negative
        if (int.TryParse(input, out int age) && age >= 0)
        {
            const double regularPrice = 10.0;
            const double discountedPrice = 7.0;
            double ticketPrice;

            // Apply discount for children and seniors
            if (age <= 12 || age >= 65)
            {
                ticketPrice = discountedPrice;
            }
            else
            {
                ticketPrice = regularPrice;
            }

            Console.WriteLine($"Your ticket price is: GHC {ticketPrice}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }
}
