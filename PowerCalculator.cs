using System;

namespace powernum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the base number: ");
            double baseNum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the exponent: ");
            double exponent = Convert.ToDouble(Console.ReadLine());

            double result;

            if (exponent == 0)
            {
                result = 1;
            }
            else if (exponent < 0)
            {
                if (baseNum == 0)
                {
                    Console.WriteLine("Error: Division by zero! Base 0 cannot have a negative exponent.");
                    return;
                }
                result = 1 / Math.Pow(baseNum, -exponent);
            }
            else
            {
                result = Math.Pow(baseNum, exponent);
            }

            Console.WriteLine($"{baseNum} raised to the power of {exponent} is: {result}");
        }
    }
}
