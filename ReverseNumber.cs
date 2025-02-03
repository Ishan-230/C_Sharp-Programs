using System;

class ReverseNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int reversedNum = 0, remainder;

        while (num > 0)
        {
            remainder = num % 10; // Get last digit
            reversedNum = (reversedNum * 10) + remainder; // Append digit to reversed number
            num /= 10; // Remove last digit
        }

        Console.WriteLine("Reversed Number: " + reversedNum);
    }
}
