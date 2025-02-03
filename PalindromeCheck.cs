using System;

class PalindromeCheck
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int originalNum = num;
        int reversedNum = 0, remainder;

        while (num > 0)
        {
            remainder = num % 10; // Get last digit
            reversedNum = (reversedNum * 10) + remainder; // Append digit to reversed number
            num /= 10; // Remove last digit
        }

        if (originalNum == reversedNum)
            Console.WriteLine("Palindrome Number");
        else
            Console.WriteLine("Not a Palindrome Number");
    }
}
