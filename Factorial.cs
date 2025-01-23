using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine($"Factorial cannot be done for negative.");
        }
        else
        {
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"The factorial of {number} is {factorial}.");
            
        }
    }
}
