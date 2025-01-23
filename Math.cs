using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"\nAddition: {num1} + {num2} = {num1 + num2}");
        Console.WriteLine($"Subtraction: {num1} - {num2} = {num1 - num2}");
        Console.WriteLine($"Multiplication: {num1} * {num2} = {num1 * num2}");

        if (num2 != 0)
        {
            Console.WriteLine($"Division: {num1} / {num2} = {num1 / num2}");
        }
        else
        {
            Console.WriteLine("Division: Error (division by zero is not allowed)");
        }

        Console.WriteLine("\nThank you for using the application!");
    }
}
