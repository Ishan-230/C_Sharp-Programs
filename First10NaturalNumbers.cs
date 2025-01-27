using System;

class Program
{
    static void Main()
    {
        int sum = 0;

        Console.WriteLine("The first 10 natural numbers are:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
            sum += i;
        }

        Console.WriteLine($"The sum of the first 10 natural numbers is: {sum}");
    }
}
